using Casimo.Data.CasimoDB;
using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.Constants;
using Casimo.Shared.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace Casimo.Server.Services.Instances;

/// <summary>
/// Service implementation for managing facility-related operations
/// Handles facility retrieval, filtering, and detailed information including subspaces and assessments
/// </summary>
public class FacilityService(ILogger<FacilityService> _logger, CasimoDbContext _casimoDbContext) : IFacilityService
{
    /// <summary>
    /// Get all facilities with pagination support.
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="page">The page number to retrieve</param>
    /// <param name="pageSize">The number of items per page</param>
    /// <param name="nameFilter">An optional filter for facility names</param>
    /// <returns>A result containing a paged list of facilities</returns>
    public async Task<Result<PagedResponse<FacilityListItemDto>>> GetAllFacilities(HttpContext httpContext, int page, int pageSize, string? nameFilter)
    {
        // Todo: filter the facility based on the users permitted organisations
        Result<PagedResponse<FacilityListItemDto>> result = new();
        try
        {
            IQueryable<TblFacility> query = _casimoDbContext.TblFacilities
                .AsNoTracking()
                .AsQueryable();

            // If the user is not an admin then the user will need to be filtered
            if (!httpContext.User.IsInRole(RoleConstants.AdminUser))
            {
                // Get the user Id
                int userId = await httpContext.UserCasimoId(_casimoDbContext);
                // Get the user 
                TblUser user = await _casimoDbContext.TblUsers.AsNoTracking().FirstAsync(x => x.UserId == userId);
                // Query should only show the lgaid 
                query = query.Where(x => x.Lgaid == user.Lgaid);
            }

            if (nameFilter is not null)
            {
                query = query.Where(x => (x.FacilitySite != null && x.FacilitySite.Contains(nameFilter))
                        || (x.Address != null && x.Address.Contains(nameFilter))
                        || (x.Address != null && x.Address.Contains(nameFilter))
                        || (x.Settlement != null && x.Settlement.Contains(nameFilter))
                        || (x.Operator != null && x.Operator.Contains(nameFilter))
                        || (x.Lgaid != null && x.Lgaid.Contains(nameFilter))
                        );
            }

            int skipValue = (page - 1) * pageSize;

            List<FacilityListItemDto> facilities = await query
                        .OrderBy(x => x.FacilitySite)
                        .Skip(skipValue)
                        .Take(pageSize)
                        .Select(x => new FacilityListItemDto()
                        {
                            FacilityId = x.FacilityId,
                            Address = x.Address,
                            Operator = x.Operator,
                            Owner = x.Owner,
                            PostCode = x.Postcode,
                            Settlement = x.Settlement,
                            SiteName = x.FacilitySite,
                            LgAid = x.Lgaid ?? ""
                        })
            .ToListAsync();

            int total = await query.CountAsync();

            // Create the paged response
            PagedResponse<FacilityListItemDto> pagedResponse = new(facilities, pageSize, page, total);
            result.Value = pagedResponse;

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting all facilities");
            result.SetError(ErrorType.InternalError, "An internal error occured when getting the facilities");
            return result;
        }
    }

    /// <summary>
    /// Get a specific facility by its ID along with its subspaces and assessment logs.
    /// </summary>
    /// <param name="facilityId">The facility Id to retrieve</param>
    /// <returns>A result containing the facility details, subspaces, and assessment logs</returns>
    public async Task<Result<FacilityDTO>> GetFacility(int facilityId)
    {
        Result<FacilityDTO> result = new();
        try
        {
            // Get the facility 
            if (await _casimoDbContext.TblFacilities
                    .AsNoTracking()
                    .Include(x => x.Status)
                    .Include(x => x.TblAssets)
                    .FirstOrDefaultAsync(x => x.FacilityId == facilityId) is not TblFacility facility)
            {
                result.SetError(ErrorType.BadRequest, "The facility for which you requested does not exist");
                return result;
            }

            // Get the Subspaces 
            List<string> subSpaces = await _casimoDbContext.TblSubSpaces
                .AsNoTracking()
                .Where(x => x.FacilityId == facilityId && x.SpaceName != null)
                .Select(x => x.SpaceName!)
                .ToListAsync();

            List<PartialAssessmentLogDto> assessmentLogs = await (
                from log in _casimoDbContext.TblFfpasstLogs
                join title in _casimoDbContext.TblFfptemplateTitles on log.TemplateId equals title.Id
                join infType in _casimoDbContext.TblInfTypes on log.InfTypeId equals infType.InfTypeId
                where log.FacilityId == facilityId
                select new PartialAssessmentLogDto()
                {
                    FacilityId = log.FacilityId,
                    LogId = log.Id,
                    Description = title.Description,
                    //AccessType = access.AccessType,
                    Use = infType.Type,
                    CouncilContactPerson = log.AssessmentPersons,
                    Date = log.AssessmentDate
                })
                .ToListAsync();

            List<FacilityStatusDto> statuses = await _casimoDbContext.TblFacilityStatuses.Select(x => new FacilityStatusDto(x.FacilityStatus ?? "", x.FacilityStatusId)).ToListAsync();
            // Get the coordinates 
            Coordinates coordinates = new(latitude: facility.YLatitude, longitude: facility.XLongitude);

            // Get the list of facilities' assessments from the assessment log
            FacilityDetailsDto facilityDetailsDto = new(facilityId: facility.FacilityId,
                    facility.FacilitySite ?? "", facility.Address ?? "",
                    postCode: facility.Postcode, suburb: facility.Settlement ?? "", owner: facility.Owner ?? "",
                    facility.Operator ?? "", status: facility.Status?.FacilityStatus ?? "",
                    coordinates, facility.Comments ?? "", facility.StatusId);

            List<FacilityRelatedAssets> relatedAssetts = [.. facility.TblAssets
                    .Select(x => new FacilityRelatedAssets()
                    {
                        AltId = x.AssetId,
                        Ref = x.AssetRef ?? "",
                        Condition = x.ConditionDescriptionOverall1 ?? "",
                    })];

            FacilityDTO res = new()
            {
                Statuses = statuses,
                FacilityDetails = facilityDetailsDto,
                FacilitySubSpaces = subSpaces,
                RelatedAssets = relatedAssetts,
                AssessmentLogs = assessmentLogs
            };

            result.Value = res;
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting all facilities");
            result.SetError(ErrorType.InternalError, "An internal error occured when getting the facilities");
            return result;
        }
    }

    /// <summary>
    /// Saves facility details to the database
    /// Updates an existing facility with new information including location, contact details, and status
    /// </summary>
    /// <param name="req">The facility details to save</param>
    /// <returns>A result containing the updated facility information or an error</returns>
    public async Task<Result<FacilityDTO>> SaveFacilityDetails(FacilityDetailsDto req)
    {
        Result<FacilityDTO> result = new();
        try
        {


            // Get the facility
            if (await _casimoDbContext.TblFacilities
                .FirstOrDefaultAsync(x => x.FacilityId == req.FacilityId) is not TblFacility facility)
            {
                result.SetError(ErrorType.BadRequest, "The facility for which you requested does not exist");
                return result;
            }

            // Set all of the values and trim the strings
            facility.FacilitySite = req.SiteName.Length > 150 ? req.SiteName[..150].Trim() : req.SiteName.Trim();
            facility.Address = req.StreetAddress.Length > 150 ? req.StreetAddress[..150].Trim() : req.StreetAddress.Trim();
            facility.Settlement = req.Suburb.Length > 150 ? req.Suburb[..150].Trim() : req.Suburb.Trim();
            facility.Operator = req.Operator.Length > 150 ? req.Operator[..150].Trim() : req.Operator.Trim();
            facility.Owner = req.Owner.Length > 150 ? req.Owner[..150].Trim() : req.Owner.Trim();
            facility.Postcode = req.PostCode;
            facility.Comments = req.Notes;
            facility.StatusId = req.StatusId;
            facility.YLatitude = req.Coordinates?.Latitude;
            facility.XLongitude = req.Coordinates?.Longitude;

            _ = await _casimoDbContext.SaveChangesAsync();

            // Return the updated factility details
            return await GetFacility(facility.FacilityId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while save all facilities");
            result.SetError(ErrorType.InternalError, "An internal error occured when saving the facilities");
            return result;
        }
    }

    /// <summary>
    /// Gets all distinct LGA IDs from the facilities
    /// </summary>
    /// <returns></returns>
    public async Task<LGAidCounts[]> GetLgAids() => await _casimoDbContext.TblFacilities
        .Where(x => x.Lgaid != null && x.XLongitude != null && x.YLatitude != null)
        .OrderByDescending(x => x.Lgaid)
        .GroupBy(x => x.Lgaid)
        .Select(x => new LGAidCounts(x.Key!, x.Count()))
        .ToArrayAsync();

    /// <summary>
    /// Retrieves the coordinates of all facilities associated with the specified LG Aid identifier.
    /// </summary>
    /// <param name="lgAid">The LG Aid identifier used to locate associated facilities. Cannot be null or empty.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an array of facility coordinates
    /// associated with the specified LG Aid. The array will be empty if no facilities are found.</returns>
    public async Task<FacilityCoords[]> GetLgAidFacility(string lgAid) => await _casimoDbContext.TblFacilities
            .Where(x => x.Lgaid == lgAid && x.XLongitude != null && x.YLatitude != null)
            .OrderBy(x => x.FacilitySite)
            .Select(x => new FacilityCoords(
                x.FacilityId,
                x.FacilitySite ?? "",
                x.XLongitude!.Value,
                x.YLatitude!.Value))
            .ToArrayAsync();
}
