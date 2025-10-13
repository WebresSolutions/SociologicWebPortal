using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.ResponseModels;
namespace Casimo.Server.Services.Interfaces;

public interface IFitForPurposeService
{
    /// <summary>
    /// Gets the broad list of assessments
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing a list of assessments</returns>
    Task<Result<List<AssessmentListItemDto>>> GetAssessmentList(HttpContext httpContext);

    /// <summary>
    /// Gets a single assessment log with all its details including questions, responses, and selections
    /// </summary>
    /// <param name="assessmentLogId">The assessment log ID to retrieve</param>
    /// <returns>A result containing the assessment log details or an error if not found</returns>
    Task<Result<AssessmentLogDetailDto>> GetAssessmentDetails(HttpContext httpContext, int assessmentLogId);

    /// <summary>
    /// Gets a list of all assessment lists available in the system
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing a list of assessment lists</returns>
    Task<Result<List<AssessmentsListDto>>> GetListOfAssessmentLists(HttpContext httpContext, bool showActiveOnly = true);

    /// <summary>
    /// Gets a user's assigned assessments grouped by assessment list
    /// </summary>
    /// <param name="userId">The user ID to get assessments for (0 for current user)</param>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <returns>A result containing the user's assessment lists with their associated assessments</returns>
    Task<Result<List<UserAssessmentListDto>>> GetAssessmentListsAssignedToUser(int userId, HttpContext httpContext);

    /// <summary>
    /// Saves a batch of question responses for an assessment log
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="req">The request containing the log ID and list of question responses to save</param>
    /// <returns>A result containing the saved question response details or an error if validation fails</returns>
    Task<Result<AssessmentLogDetailDto>> SaveQuestionResponses(HttpContext httpContext, SaveQuestionResListDto req);

    /// <summary>
    /// Gets all users assigned to a specific assessment list with their roles
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="assessmentListId">The assessment list ID to get users for</param>
    /// <returns>A result containing an array of users with their role information</returns>
    Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToList(HttpContext httpContext, int assessmentListId);

    /// <summary>
    /// Gets all users assigned to a specific assessment with their roles
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="assessmentId">The assessment ID to get users for</param>
    /// <returns>A result containing an array of users with their role information</returns>
    Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToAssessment(HttpContext httpContext, int assessmentId);

    /// <summary>
    /// Creates or updates a list of assessment list assessments
    /// </summary>
    /// <param name="httpContext">The Http Context</param>
    /// <param name="req">The request which contains details for saving a list of assessments</param>
    /// <returns>A result containing an AssessmentListResponseDto</returns>
    Task<Result<AssessmentListResponseDto>> SaveAssessmentList(HttpContext httpContext, AssessmentListRequestDto req);

    /// <summary>
    /// Removes a list
    /// </summary>
    /// <param name="listId"></param>
    /// <returns></returns>
    Task<Result<bool>> RemoveList(int listId);
}
