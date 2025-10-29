using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;

namespace Casimo.Server.Services.Interfaces;

public interface IFacilityService
{
    /// <summary>
    /// Get all facilities with pagination support.
    /// </summary>
    /// <param name="httpContext">The http context of the calling user</param>
    /// <param name="page">The page number to retrieve</param>
    /// <param name="pageSize">The number of items per page</param>
    /// <param name="nameFilter">An optional filter for facility names</param>
    /// <returns>A result containing a paged list of facilities</returns>
    Task<Result<PagedResponse<FacilityListItemDto>>> GetAllFacilities(HttpContext httpContext, int page, int pageSize, string? nameFilter, string? orderby, SortDirectionEnum order);

    /// <summary>
    /// Get a specific facility by its ID along with its subspaces and assessment logs.
    /// </summary>
    /// <param name="facilityId">The facility Id to retrieve</param>
    /// <returns>A result containing the facility details, subspaces, and assessment logs</returns>
    Task<Result<FacilityDTO>> GetFacility(int facilityId);

    /// <summary>
    /// Saves the details of a facility
    /// </summary>
    /// <param name="req">The request</param>
    /// <returns>The save file dto</returns>
    Task<Result<FacilityDTO>> SaveFacilityDetails(FacilityDetailsDto req);

    /// <summary>
    /// Gets a list of LGaids
    /// </summary>
    /// <returns></returns>
    Task<LGAidCounts[]> GetLgAids();

    /// <summary>
    /// Retrieves the coordinates of all facilities associated with the specified LG Aid identifier.
    /// </summary>
    /// <param name="lgAid">The LG Aid identifier used to locate associated facilities. Cannot be null or empty.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains an array of facility coordinates
    /// associated with the specified LG Aid. The array will be empty if no facilities are found.</returns>
    Task<FacilityCoords[]> GetLgAidFacility(string lgAid);
}
