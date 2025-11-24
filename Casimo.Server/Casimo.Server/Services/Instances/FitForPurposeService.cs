using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Server.Strings;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Constants;
using Casimo.Shared.Enums;
using Casimo.Shared.Helpers;
using Casimo.Shared.ResponseModels;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace Casimo.Server.Services.Instances;

public class FitForPurposeService(CasimoDbContext _casimoDB, ILogger<FitForPurposeService> _logger, AuthDBContext _authDB) : IFitForPurposeService
{
    /// <summary>
    /// Gets the broad list of assessments
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing a list of assessments</returns>
    public async Task<Result<List<AssessmentListItemDto>>> GetAssessmentList(HttpContext httpContext)
    {
        Result<List<AssessmentListItemDto>> res = new();
        try
        {
            string? lgaidFilter = null;
            // If the user is not an admin then the user will need to be filtered
            if (!httpContext.User.IsInRole(RoleConstants.AdminUser))
            {
                // Get the user Id
                int userId = await httpContext.UserCasimoId(_casimoDB);
                // Get the user 
                TblUser user = await _casimoDB.TblUsers.AsNoTracking().FirstAsync(x => x.UserId == userId);
                // Query should only show the lgaid 
                lgaidFilter = user.Lgaid ?? throw new Exception("Failed to get user lgaid");
            }

            List<AssessmentListItemDto> assessments = await (
                from log in _casimoDB.TblFfpasstLogs
                join template in _casimoDB.TblFfptemplateTitles on log.TemplateId equals template.Id
                join facility in _casimoDB.TblFacilities on log.FacilityId equals facility.FacilityId
                join infType in _casimoDB.TblInfTypes on log.InfTypeId equals infType.InfTypeId
                join status in _casimoDB.TblAssessmentStatuses on log.StatusId equals status.Id
                where lgaidFilter == null || facility.Lgaid == lgaidFilter
                orderby log.Id descending
                select new AssessmentListItemDto()
                {
                    FacilityId = log.FacilityId,
                    AssessmentLogId = log.Id,
                    FacilityName = facility.FacilitySite ?? string.Empty,
                    TemplateDescription = template.Description ?? string.Empty,
                    TemplateTitle = template.Title,
                    Use = infType.Type ?? string.Empty,
                    Status = ((AssessmentStatusEnum)status.Id).GetDisplayName(),
                    StatusId = status.Id,
                    LgAid = facility.Lgaid ?? "",
                    LastEdited = log.LastEdited,
                    LastEditedBy = log.LastEditedBy,
                    AssessmentDate = log.AssessmentDate,
                    FacilityComponent = facility.FacilityComponent ?? string.Empty,
                }
                ).ToListAsync();

            res.Value = assessments;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment list";
            return res;
        }
    }

    /// <summary>
    /// Gets a single assessment log with all its details including questions, responses, and selections
    /// </summary>
    /// <param name="assessmentLogId">The assessment log ID to retrieve</param>
    /// <returns>A result containing the assessment log details or an error if not found</returns>
    public async Task<Result<AssessmentLogDetailDto>> GetAssessmentDetails(HttpContext httpContext, int assessmentLogId)
    {
        Result<AssessmentLogDetailDto> res = new();
        try
        {
            // Temporary users can only view assessments which they are assigned to
            if (!await UserIsAbleToViewAssessment(httpContext, assessmentLogId))
            {
                res.ErrorDescription = BadRequestResponses.MissingPermissionsToViewAssessments;
                res.Error = ErrorType.Unauthorized;
                return res;
            }

            // Get the log 
            var logInfo = await _casimoDB.TblFfpasstLogs
                .AsNoTracking()
                .Include(x => x.Template)
                .Where(x => x.Id == assessmentLogId)
                .Select(x => new
                {
                    x.Id,
                    x.TemplateId,
                    x.FacilityId,
                    InfType = _casimoDB.TblInfTypes.FirstOrDefault(x => x.InfTypeId == x.InfTypeId),
                    statusId = x.Status.Id,
                    TemplateName = x.Template.Description ?? string.Empty,
                    FacilityName = _casimoDB.TblFacilities.FirstOrDefault(f => f.FacilityId == x.FacilityId)!.FacilitySite,
                    x.Template.SchemeId,
                    x.LastEdited
                })
                .FirstOrDefaultAsync();

            if (logInfo is null)
            {
                res.ErrorDescription = "Could not find the assessment";
                res.Error = ErrorType.NotFound;
                return res;
            }

            // Get the question responses separately
            List<SectionDetailDto> sectionsWithQuestions = await _casimoDB.TblFfptemplateSections
             .AsNoTracking()
             .Where(s => s.TemplateId == logInfo.TemplateId)
             .GroupJoin(
                 _casimoDB.TblFfpasstSectionResponses.Where(r => r.LogId == assessmentLogId),
                 section => section.Id,
                 response => response.SectionId,
                 (section, responseGroup) => new { Section = section, Responses = responseGroup })
             .SelectMany(
                 x => x.Responses.DefaultIfEmpty(),
                 (section, sectionResponse) => new SectionDetailDto
                 {
                     SectionId = section.Section.Id,
                     SectionNumber = section.Section.SectionNumber,
                     SectionTitle = section.Section.SectionTitle,
                     IsGencomment = section.Section.GenComment == true,
                     IsAssetComment = section.Section.AssetComment == true,
                     CommentNumber = section.Section.CommentNumber,
                     IsOtherComment = section.Section.GenComment == false && section.Section.AssetComment == false,
                     SummaryRequired = section.Section.SummaryRequired ?? false,
                     // Handle null response for sections with no response
                     Summary = sectionResponse != null ? sectionResponse.Summary ?? "" : "",
                     FFPScore = sectionResponse != null ? sectionResponse.SectionScore1 : (decimal)0.0,
                     Questions = section.Section.TblFfptemplateQuestions.Select(
                         q => new QuestionResponseDetailDto
                         {
                             QuestionId = q.Id,
                             Subsection = q.Subsection ?? string.Empty,
                             QuestionTitle = q.QuestionTitle ?? string.Empty,
                             QuestionText = q.QuestionText ?? string.Empty,
                             HelpComments = q.HelpComments,
                         }).ToList()
                 })
             .ToListAsync();

            // Get all responses in one query
            Dictionary<int, TblFfpasstQuestionResponse> responses = await _casimoDB.TblFfpasstQuestionResponses
                .AsNoTracking()
                .Where(r => r.LogId == assessmentLogId)
                .ToDictionaryAsync(r => r.QuestionId, r => r);

            // Get the summaries
            List<SectionDetailDto> ffpSections = [.. sectionsWithQuestions
                .Where(x => x is { IsGencomment: false, IsAssetComment: false, Questions: not [] })];
            List<SectionDetailDto> generalComments = [.. sectionsWithQuestions
                .Where(x => x.IsGencomment || (x.IsAssetComment && x.Questions.Count != 0) || x.CommentNumber != 0)
                .OrderBy(x => x.CommentNumber)];
            List<SectionDetailDto> categorySummaries = [.. sectionsWithQuestions
                .Where(x => x.SummaryRequired)];

            foreach (QuestionResponseDetailDto question in ffpSections.SelectMany(section => section.Questions))
            {
                if (!responses.TryGetValue(question.QuestionId, out TblFfpasstQuestionResponse? response))
                    continue;

                question.ResponseText1 = response.ResponseText1 ?? "";
                question.ResponseText2 = response.ResponseText2 ?? "";
                question.Selection1Id = response.Selection1Id;
                question.Selection2Id = response.Selection2Id;
            }

            foreach (QuestionResponseDetailDto question in generalComments.SelectMany(section => section.Questions))
            {
                if (!responses.TryGetValue(question.QuestionId, out TblFfpasstQuestionResponse? response))
                    continue;

                question.ResponseText1 = response.ResponseText1 ?? "";
                question.ResponseText2 = response.ResponseText2 ?? "";
            }

            // Get the selection list 
            List<AssessmentSelectionDto> selections = await _casimoDB.TblFfpasstSelections
                .AsNoTracking()
                .Where(x => x.SchemeId == logInfo.SchemeId || x.Id == 1)
                .OrderBy(x => x.SelectionOrder)
                .Select(a => new AssessmentSelectionDto()
                {
                    SelectionId = a.Id,
                    SelectionName = a.SelectionText
                }).ToListAsync();

            AssessmentLogDetailDto assessmentLogDetail = new()
            {
                LogId = logInfo.Id,
                TemplateId = logInfo.TemplateId,
                TemplateName = logInfo.TemplateName,
                FacilityId = logInfo.FacilityId,
                FacilityName = logInfo.FacilityName ?? "",
                Sections = ffpSections,
                GeneralComments = generalComments,
                SectionSummaries = categorySummaries,
                SelectionList = selections,
                StatusName = ((AssessmentStatusEnum)logInfo.statusId).GetDisplayName(),
                StatusId = logInfo.statusId,
                Use = logInfo.InfType?.Type ?? string.Empty,
                LastEdited = logInfo.LastEdited
            };
            res.Value = assessmentLogDetail;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while getting assessment template for assessment log {AssessmentLogId}", assessmentLogId);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment template.";
            return res;
        }
    }

    /// <summary>
    /// Gets a list of all assessment lists available in the system
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing a list of assessment lists</returns>
    public async Task<Result<List<AssessmentsListDto>>> GetListOfAssessmentLists(HttpContext httpContext, bool showActiveOnly = true)
    {
        Result<List<AssessmentsListDto>> res = new();
        try
        {
            List<AssessmentsListDto> assessmentLists = await
                (from list in _casimoDB.TblAssessmentLists
                 join listAssessment in _casimoDB.TblAssessmentListAssessments on list.Id equals listAssessment.ListId
                 join log in _casimoDB.TblFfpasstLogs on listAssessment.LogId equals log.Id
                 join facility in _casimoDB.TblFacilities on log.FacilityId equals facility.FacilityId
                 join template in _casimoDB.TblFfptemplateTitles on log.TemplateId equals template.Id
                 where !showActiveOnly || list.Active
                 group new { listAssessment, log, facility, template } by new { list.Id, list.ListName, list.Description, list.Active, list.DateAdded } into listGroup
                 select new AssessmentsListDto(
                     listGroup.Key.Id,
                     listGroup.Key.ListName ?? "",
                     listGroup.Key.Description ?? "",
                     listGroup.Key.Active,
                     listGroup.Key.DateAdded,
                     listGroup.Select(item => new AssessmentLogPartialDto(
                         item.log.Id,
                         item.template.Description ?? "Template",
                         item.facility.FacilitySite ?? "Facility Name",
                         item.log.FacilityId,
                         item.log.Status.Id,
                         ((AssessmentStatusEnum)item.log.Status.Id).GetDisplayName()
                     )).ToList()
                 ))
                .ToListAsync();

            res.Value = assessmentLists;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Error occured while getting the list of assessments");
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment template.";
            return res;
        }
    }

    /// <summary>
    /// Gets a user's assigned assessments grouped by assessment list
    /// </summary>
    /// <param name="userId">The user ID to get assessments for (0 for current user)</param>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing the user's assessment lists with their associated assessments</returns>
    public async Task<Result<List<UserAssessmentListDto>>> GetAssessmentListsAssignedToUser(int userId, HttpContext httpContext)
    {
        Result<List<UserAssessmentListDto>> res = new();
        try
        {
            // If the user Id is null then get the currently logged in user
            if (userId is 0)
                userId = await httpContext.UserCasimoId(_casimoDB);

            List<UserAssessmentListDto> assessmentListsGrouped = await
                (from userAssignedList in _casimoDB.TblUserAssignedAssessmentLists
                 join listList in _casimoDB.TblAssessmentLists on userAssignedList.ListId equals listList.Id
                 join list in _casimoDB.TblAssessmentListAssessments on userAssignedList.ListId equals list.ListId
                 join log in _casimoDB.TblFfpasstLogs on list.LogId equals log.Id
                 join status in _casimoDB.TblAssessmentStatuses on log.StatusId equals status.Id
                 join facility in _casimoDB.TblFacilities on log.FacilityId equals facility.FacilityId
                 join template in _casimoDB.TblFfptemplateTitles on log.TemplateId equals template.Id
                 where userAssignedList.UserId == userId && listList.Active == true
                 select new
                 {
                     userAssignedList.ListId,
                     AssessmentLogId = log.Id,
                     FacilityName = facility.FacilitySite ?? "",
                     TemplateName = template.Title,
                     desc = template.Description,
                     listList.ListName,
                     listList.Description,
                     facility.FacilityId,
                     statusName = status.Name,
                     statusId = status.Id,
                     When = log.LastEdited,
                     Who = log.LastEditedBy
                 })
                .GroupBy(x => new { x.ListId, x.ListName, x.Description })
                .Select(group => new UserAssessmentListDto()
                {
                    ListId = group.Key.ListId,
                    AssessmentListName = group.Key.ListName,
                    Description = group.Key.Description,
                    AssessmentList = group.Select(item => new AssessmentListItemDto()
                    {
                        AssessmentLogId = item.AssessmentLogId,
                        FacilityName = item.FacilityName,
                        TemplateDescription = item.desc,
                        FacilityId = item.FacilityId,
                        Status = item.statusName,
                        StatusId = item.statusId,
                        LastEdited = item.When,
                        LastEditedBy = item.Who,
                        Use = item.TemplateName
                    }).ToList()
                })
                .ToListAsync();

            res.Value = assessmentListsGrouped;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while getting assessment template for assessment log {AssessmentLogId}", userId);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment template.";
            return res;
        }
    }

    /// <summary>
    /// Saves a batch of question responses for an assessment log
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="req">The request containing the log ID and list of question responses to save</param>
    /// <returns>A result containing the saved question response details or an error if validation fails</returns>
    public async Task<Result<AssessmentLogDetailDto>> SaveQuestionResponses(HttpContext httpContext,
        SaveQuestionResListDto req)
    {
        Result<AssessmentLogDetailDto> res = new();

        if (!await UserIsAbleToViewAssessment(httpContext, req.LogId))
        {
            res.ErrorDescription = BadRequestResponses.MissingPermissionsToViewAssessments;
            res.Error = ErrorType.Unauthorized;
            return res;
        }

        try
        {
            string userName = await httpContext.UserName(_casimoDB);

            // Get the log
            TblFfpasstLog? log = await _casimoDB.TblFfpasstLogs.FirstOrDefaultAsync(x => x.Id == req.LogId);
            if (log is null)
            {
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = $"Invalid log. Log not found.";
                return res;
            }

            if (req.SubmissionType is not null)
                log.StatusId = (int)req.SubmissionType;

            // Validate the question IDs
            int[] questionIds = [.. req.QuestionList.Select(x => x.QuestionId).Distinct()];
            // Validate the existence of all questions 
            List<int> existingQuestionIds = await _casimoDB.TblFfptemplateQuestions
                .Where(x => questionIds.Contains(x.Id))
                .Select(x => x.Id)
                .ToListAsync();

            if (existingQuestionIds.Count != questionIds.Length)
            {
                IEnumerable<int> missingIds = questionIds.Except(existingQuestionIds);
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = $"Invalid question IDs: {string.Join(", ", missingIds)}";
                return res;
            }
            await SaveQuestionList(req, questionIds);

            // Save the section summaries
            if (req.SectionSummaryList is not null or [])
            {
                // Validate the section summaries
                int[] sectionIds = [.. req.SectionSummaryList!.Select(x => x.SectionId)];
                TblFfptemplateSection[] tblFfptemplateSections = await _casimoDB.TblFfptemplateSections.Where(x => sectionIds.Contains(x.Id)).ToArrayAsync();
                if (sectionIds.Length != tblFfptemplateSections.Length)
                {
                    res.Error = ErrorType.NotFound;
                    res.ErrorDescription = $"Invalid section Ids";
                    return res;
                }
                await SaveQuestionResponse(req, sectionIds);
            }

            /// Update the last edited info if there are any changes. 
            /// Because the FE saves every time a field has been edited or changed we need to check if there are any changes to avoid updating the last edited info every time
            if (_casimoDB.ChangeTracker.HasChanges())
            {
                log.LastEditedBy = userName;
                log.LastEdited = DateTime.UtcNow;
            }

            // Commit all changes to the database
            _ = await _casimoDB.SaveChangesAsync();

            return await GetAssessmentDetails(httpContext, log.Id);
        }
        catch (Exception ex)
        {
            // Ensure 'requests' is not null before trying to join its LogIds
            string logIds = req != null && req.QuestionList.Count != 0 ? string.Join(", ", req.QuestionList.Select(r => r.QuestionId)) : "N/A";
            _logger.LogError(ex, "Error while saving a batch of question responses. Question IDs involved: {LogIds}", logIds);

            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while saving the question responses batch.";
            return res;
        }
    }

    /// <summary>
    /// Gets all users assigned to a specific assessment list with their roles
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="assessmentListId">The assessment list ID to get users for</param>
    /// <returns>A result containing an array of users with their role information</returns>
    public async Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToList(HttpContext httpContext, int assessmentListId)
    {
        Result<UsersAssignedToAssessmentDto[]> res = new();
        try
        {
            if (!await _casimoDB.TblAssessmentLists.AnyAsync(x => x.Id == assessmentListId))
            {
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = "Could not find the assessment list";
                return res;
            }

            // First query: Get users from main database
            var users = await
                (from list in _casimoDB.TblAssessmentListAssessments
                 join userList in _casimoDB.TblUserAssignedAssessmentLists on list.ListId equals userList.ListId
                 join user in _casimoDB.TblUsers on userList.UserId equals user.UserId
                 where list.ListId == assessmentListId
                 select new { user.UserName, user.IdentityId, user.UserId })
                .Distinct()
                .ToArrayAsync();

            if (users.Length is 0)
            {
                res.Value = [];
                return res;
            }

            // Second query: Get roles from auth database
            string[] identityIds = [.. users.Select(u => u.IdentityId).Distinct()];
            var userRoles = await
                (from ur in _authDB.UserRoles
                 join role in _authDB.Roles on ur.RoleId equals role.Id
                 where identityIds.Contains(ur.UserId)
                 select new { ur.UserId, role.NormalizedName })
                .Distinct()
                .ToArrayAsync();

            // Combine the results in memory
            UsersAssignedToAssessmentDto[] usersAssessments = [.. users.Select(user =>
            {
                var role = userRoles.FirstOrDefault(ur => ur.UserId == user.IdentityId);
                return new UsersAssignedToAssessmentDto(
                    user.UserName ?? "",
                    role?.NormalizedName ?? "",
                    user.IdentityId ?? "",
                    user.UserId);
            })];

            res.Value = usersAssessments;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Error occured while getting the list of assessments");
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment template.";
            return res;
        }
    }

    /// <summary>
    /// Gets all users assigned to a specific assessment with their roles
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="assessmentId">The assessment ID to get users for</param>
    /// <returns>A result containing an array of users with their role information</returns>
    public async Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToAssessment(HttpContext httpContext, int assessmentId)
    {
        Result<UsersAssignedToAssessmentDto[]> res = new();
        try
        {
            if (!await _casimoDB.TblFfpasstLogs.AnyAsync(x => x.Id == assessmentId))
            {
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = "Could not find the assessment";
                return res;
            }

            // First query: Get users from main database
            var users = await
                (from log in _casimoDB.TblAssessmentListAssessments
                 join userList in _casimoDB.TblUserAssignedAssessmentLists on log.ListId equals userList.ListId  // Fixed join condition
                 join user in _casimoDB.TblUsers on userList.UserId equals user.UserId
                 where log.LogId == assessmentId && log.List.Active == true
                 select new { user.UserName, user.IdentityId, user.UserId })
                .Distinct()
                .ToArrayAsync();

            if (users.Length is 0)
            {
                res.Value = [];
                return res;
            }

            // Second query: Get roles from auth database
            string[] identityIds = [.. users.Select(u => u.IdentityId).Distinct()];
            var userRoles = await
                (from ur in _authDB.UserRoles
                 join role in _authDB.Roles on ur.RoleId equals role.Id
                 where identityIds.Contains(ur.UserId)
                 select new { ur.UserId, role.NormalizedName })
                .Distinct()
                .ToArrayAsync();

            // Combine the results in memory
            UsersAssignedToAssessmentDto[] usersAssessments = [.. users.Select(user =>
            {
                var role = userRoles.FirstOrDefault(ur => ur.UserId == user.IdentityId);
                return new UsersAssignedToAssessmentDto(
                    user.UserName ?? "",
                    role?.NormalizedName ?? "",
                    user.IdentityId ?? "",
                    user.UserId);
            })];

            res.Value = usersAssessments;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Error occured while getting the list of assessments");
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occurred while retrieving the assessment template.";
            return res;
        }
    }

    /// <summary>
    /// Saves a bunch of assessments to an assessments list.
    /// If list ID is 0 then create a new one otherwise the list will be updated.
    /// </summary>
    /// <param name="httpContext">The httpcontext of the callers</param>
    /// <param name="req">The request for saving</param>
    /// <returns>A result which contains a value or an error</returns>
    public async Task<Result<AssessmentListResponseDto>> SaveAssessmentList(HttpContext httpContext, AssessmentListRequestDto req)
    {
        Result<AssessmentListResponseDto> res = new();
        try
        {
            TblAssessmentList? assessmentList;

            req.AssessmentListName ??= string.Empty;
            req.AssessmentListName = req.AssessmentListName.Length > 255 ? req.AssessmentListName[..255] : req.AssessmentListName;

            req.AssessmentListDescription ??= string.Empty;
            req.AssessmentListDescription = req.AssessmentListDescription.Length > 500 ? req.AssessmentListDescription[..500] : req.AssessmentListDescription;

            if (req.AssessmentListId is not 0)
            {
                assessmentList = await _casimoDB.TblAssessmentLists.FirstOrDefaultAsync(x => x.Id == req.AssessmentListId);
                if (assessmentList is null)
                {
                    res.Error = ErrorType.NotFound;
                    res.ErrorDescription = $"Assessments list {req.AssessmentListId} not found";
                    return res;
                }

                assessmentList.Description = req.AssessmentListDescription;
                assessmentList.ListName = req.AssessmentListName;
            }
            else
            {
                assessmentList = new()
                {
                    Description = req.AssessmentListDescription,
                    ListName = req.AssessmentListName,
                };
                _ = await _casimoDB.TblAssessmentLists.AddAsync(assessmentList);
            }
            assessmentList.Active = true;

            req.AssessmentLogIds = [.. req.AssessmentLogIds.Distinct()];

            TblFfpasstLog[] assessments = await _casimoDB.TblFfpasstLogs.Where(x => req.AssessmentLogIds.Contains(x.Id)).AsNoTracking().ToArrayAsync();
            if (assessments.Length != req.AssessmentLogIds.Count)
            {
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = $"Assessments list {req.AssessmentListId} not found";
                return res;
            }

            _ = await _casimoDB.SaveChangesAsync();

            DateTime timeStamp = DateTime.UtcNow;
            List<TblAssessmentListAssessment> assessmentListAssessments = [.. assessments.Select(log => new TblAssessmentListAssessment() { ListId = assessmentList.Id, LogId = log.Id, DateAdded = timeStamp })];

            // brute force but just delete all assessment 2 lists with that list ID
            _ = await _casimoDB.TblAssessmentListAssessments
                .Where(x => x.ListId == assessmentList.Id)
                .ExecuteDeleteAsync();

            await _casimoDB.TblAssessmentListAssessments.AddRangeAsync(assessmentListAssessments);
            _ = await _casimoDB.SaveChangesAsync();

            res.Value = new()
            {
                AssessmentListDescription = req.AssessmentListDescription,
                AssessmentLogIds = [.. assessmentListAssessments.Select(x => x.LogId)],
                AssessmentListName = req.AssessmentListName,
                AssessmentListId = assessmentList.Id
            };
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Error occured while creating the list of assessments");
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An error occured while creating the list of assessments.";
            return res;
        }
    }

    /// <summary>
    /// Removes an assessment list and all its associated data
    /// Deletes the assessment list, user assignments, and assessment associations
    /// </summary>
    /// <param name="listId">The ID of the assessment list to remove</param>
    /// <returns>A result indicating success or failure of the removal operation</returns>
    public async Task<Result<bool>> RemoveList(int listId)
    {
        Result<bool> res = new();
        try
        {
            // Delete all of the user list wwith matching id 
            TblAssessmentList? list = await _casimoDB.TblAssessmentLists.FirstOrDefaultAsync(x => x.Id == listId);
            if (list is null)
            {
                res.Error = ErrorType.NotFound;
                res.ErrorDescription = "Could not find the assessment list";
                return res;
            }

            list.Active = false;
            _ = await _casimoDB.SaveChangesAsync();

            res.Value = true;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An Error occured while removing the list of assessments.");
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "An Error occured while removing the list of assessments.";
            return res;
        }
    }

    #region Private Methods

    /// <summary>
    /// Validates the calling users permissions to view an assessment
    /// </summary>
    /// <param name="httpContext">The http context of the calling user </param>
    /// <param name="assessmentId">The assessment Id</param>
    /// <returns>True if has valid permissions otherwise false</returns>
    private async Task<bool> UserIsAbleToViewAssessment(HttpContext httpContext, int assessmentId)
    {
        if (httpContext.User.IsInRole(RoleConstants.AdminUser) || httpContext.User.IsInRole(RoleConstants.FullUser))
            return true;

        if (httpContext.User.IsInRole(RoleConstants.TemporaryUser))
        {
            int userId = await httpContext.UserCasimoId(_casimoDB);

            // Get their list of assessment lists
            TblFfpasstLog[] assessments = await _casimoDB.TblUserAssignedAssessmentLists
                .AsNoTracking()
                .Include(x => x.List)
                    .ThenInclude(list => list.TblAssessmentListAssessments)
                    .ThenInclude(assessment => assessment.Log)
                .Where(x => x.UserId == userId && x.List.Active == true)
                .SelectMany(x => x.List.TblAssessmentListAssessments)
                .Select(x => x.Log)
                .ToArrayAsync();

            return assessments.Any(x => x.Id == assessmentId);
        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// Saves the section summary responses
    /// </summary>
    /// <param name="req">The request to be saved</param>
    /// <param name="sectionIds">The sections Ids</param>
    /// <returns></returns>
    private async Task SaveQuestionResponse(SaveQuestionResListDto req, int[] sectionIds)
    {
        TblFfpasstSectionResponse[] sectionResponses = await _casimoDB.TblFfpasstSectionResponses
            .Where(x => sectionIds.Contains(x.SectionId) && x.LogId == req.LogId)
            .ToArrayAsync();

        // Prepare a list of new section responses to be added instead of adding them one by one to the database
        List<TblFfpasstSectionResponse> sectionResponsesToSave = [];
        foreach (SectionSummarySaveDto summary in req.SectionSummaryList ?? [])
        {
            // Find the section summary response 
            TblFfpasstSectionResponse? sectionResponse = sectionResponses.FirstOrDefault(x => x.SectionId == summary.SectionId && x.LogId == req.LogId);
            // Create a new one or update and existing
            if (sectionResponse is null)
            {
                sectionResponse = new()
                {
                    SectionId = summary.SectionId,
                    LogId = req.LogId,
                    Summary = summary.SectionSummary?.Trim(),
                    SectionScore1 = summary.SectionScore
                };
                sectionResponsesToSave.Add(sectionResponse);
            }
            else
            {
                sectionResponse.SectionScore1 = summary.SectionScore;
                sectionResponse.Summary = summary.SectionSummary?.Trim();
            }
        }
        if (sectionResponsesToSave.Count > 0)
            await _casimoDB.TblFfpasstSectionResponses.AddRangeAsync(sectionResponsesToSave);
    }

    /// <summary>
    /// Saves a question list to the database
    /// </summary>
    /// <param name="req">The request containing the questions</param>
    /// <param name="questionIds">The question Ids to be validated</param>
    /// <param name="savedResponseDetails">The dto being updated</param>
    /// <returns>A list of saved response details</returns>
    private async Task SaveQuestionList(SaveQuestionResListDto req, int[] questionIds)
    {
        // Get all of the questions in one go to remove looped calls to the database
        TblFfpasstQuestionResponse[] responses = await _casimoDB.TblFfpasstQuestionResponses
            .Where(x => questionIds.Contains(x.QuestionId) && x.LogId == req.LogId)
            .ToArrayAsync();
        // Prepare a list of new question responses to be added instead of adding them one by one to the database
        List<TblFfpasstQuestionResponse> questionsResponsesToAdd = [];
        foreach (SaveQuestionResponseDto qres in req.QuestionList)
        {
            // Find an existing response based on the question ID and the log ID
            TblFfpasstQuestionResponse? questionResponse = responses
                .FirstOrDefault(qr => qr.QuestionId == qres.QuestionId && qr.LogId == req.LogId);

            if (questionResponse is null)
            {
                questionResponse = new()
                {
                    LogId = req.LogId,
                    QuestionId = qres.QuestionId,
                    ResponseText1 = qres.Response1?.Trim(),
                    ResponseText2 = qres.Response2?.Trim(),
                    Selection1Id = qres.SelectionId1,
                    Selection2Id = qres.SelectionId2,
                };
                questionsResponsesToAdd.Add(questionResponse);
            }
            else
            {
                questionResponse.ResponseText1 = qres.Response1?.Trim();
                questionResponse.ResponseText2 = qres.Response2?.Trim();
                questionResponse.Selection1Id = qres.SelectionId1;
                questionResponse.Selection2Id = qres.SelectionId2;
            }
        }

        if (questionsResponsesToAdd.Count > 0)
            await _casimoDB.TblFfpasstQuestionResponses.AddRangeAsync(questionsResponsesToAdd);
    }
    #endregion
}