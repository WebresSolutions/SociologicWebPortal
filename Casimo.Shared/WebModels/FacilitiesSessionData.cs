using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.Enums;

namespace Casimo.Shared.WebModels;


/// <summary>
/// Session data for the Facilities page
/// </summary>
public class FacilitiesSessionData
{
    public int Page { get; set; } = 0;
    public int PageSize { get; set; } = 25;
    public string? SearchString { get; set; }
    public string OrderBy { get; set; } = nameof(FacilityListItemDto.SiteName);
    public SortDirectionEnum Order { get; set; } = SortDirectionEnum.Asc;
}