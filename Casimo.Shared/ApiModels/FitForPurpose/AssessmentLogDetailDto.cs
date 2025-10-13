namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Comprehensive data transfer object for assessment log details
/// Contains complete assessment information including sections, questions, and selections
/// </summary>
public class AssessmentLogDetailDto
{
    /// <summary>
    /// Gets or sets the assessment log identifier
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Gets or sets the status identifier for the assessment
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Gets or sets the human-readable status name for the assessment
    /// </summary>
    public string StatusName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the unique identifier for the assessment template
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// Gets or sets the name of the assessment template
    /// </summary>
    public string TemplateName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the facility being assessed
    /// </summary>
    public string FacilityName { get; set; } = string.Empty;

    /// <summary>
    /// The use of the assessment from the inf type table
    /// </summary>
    public string? Use { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the facility
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Get or sets the local government area identifier
    /// </summary>
    public DateTime? LastEdited { get; set; }

    /// <summary>
    /// Gets or sets the list of fit for purpose assessment sections
    /// Contains detailed question and response information organized by sections
    /// </summary>
    public List<SectionDetailDto> Sections { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of general comments sections
    /// Contains high-level assessment comments and summaries
    /// </summary>
    public List<SectionDetailDto> GeneralComments { get; set; } = [];

    /// <summary>
    /// The list of section summaries for each
    /// </summary>
    public List<SectionDetailDto> SectionSummaries { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of available assessment selections
    /// Contains predefined options for assessment responses
    /// </summary>
    public List<AssessmentSelectionDto>? SelectionList { get; set; }
}

/// <summary>
/// Data transfer object for assessment selection options
/// Represents predefined choices available for assessment responses
/// </summary>
public class AssessmentSelectionDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the selection option
    /// </summary>
    public int? SelectionId { get; set; }

    /// <summary>
    /// Gets or sets the display name for the selection option
    /// </summary>
    public string? SelectionName { get; set; }
}