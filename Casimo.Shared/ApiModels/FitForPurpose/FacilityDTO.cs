using Casimo.Shared.ApiModels.Facility;

namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Comprehensive data transfer object for fitness for purpose assessments
/// Contains facility details, subspaces, assessments, and related assets
/// </summary>
public class FacilityDTO
{
    /// <summary>
    /// Gets or sets the detailed facility information
    /// Contains comprehensive facility data including location, ownership, and status
    /// </summary>
    public FacilityDetailsDto FacilityDetails { get; set; }

    /// <summary>
    /// Gets or sets the list of subspaces within the facility
    /// Represents different areas or sections of the facility
    /// </summary>
    public List<string> FacilitySubSpaces { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of assessments conducted for the facility
    /// Contains assessment logs with their current status and details
    /// </summary>
    public List<PartialAssessmentLogDto> AssessmentLogs { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of related assets for the facility
    /// Contains equipment, infrastructure, and other assets associated with the facility
    /// </summary>
    public List<FacilityRelatedAssets> RelatedAssets { get; set; } = [];

    /// <summary>
    /// List of statuses
    /// </summary>
    public List<FacilityStatusDto> Statuses { get; set; }
}