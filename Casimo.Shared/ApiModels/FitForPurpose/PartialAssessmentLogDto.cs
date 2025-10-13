namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for partial assessment log information
/// Contains essential assessment details for list displays and summaries
/// </summary>
public class PartialAssessmentLogDto
{
    /// <summary>
    /// Gets or sets the assessment log identifier
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Gets or sets the facility identifier associated with the assessment
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Gets or sets the assessment access type
    /// Indicates how the assessment was accessed or conducted
    /// </summary>
    public string? AccessType { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the assessment description
    /// Provides a brief overview of the assessment purpose and scope
    /// </summary>
    public string? Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the use case for the assessment
    /// Describes the intended purpose or function being assessed
    /// </summary>
    public string? Use { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the council contact person for the assessment
    /// Primary point of contact for council-related matters
    /// </summary>
    public string? CouncilContactPerson { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date when the assessment was conducted
    /// </summary>
    public DateTime Date { get; set; }
}