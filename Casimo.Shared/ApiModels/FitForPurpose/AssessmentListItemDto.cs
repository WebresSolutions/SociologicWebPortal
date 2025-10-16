namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for assessment list items
/// Contains summary information for displaying assessments in lists and grids
/// </summary>
public class AssessmentListItemDto
{
    /// <summary>
    /// Gets or sets the assessment log identifier
    /// </summary>
    public int AssessmentLogId { get; set; }

    /// <summary>
    /// Gets or sets the name of the facility being assessed
    /// </summary>
    public string FacilityName { get; set; } = string.Empty;

    /// <summary>
    /// Facility Component
    /// </summary>
    public string FacilityComponent { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the assessment template
    /// </summary>
    public string TemplateDescription { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the title of the assessment template
    /// </summary>
    public string TemplateTitle { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the facility identifier
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Gets or sets the status name of the assessment
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the status identifier of the assessment
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Gets or sets the intended use of the facility
    /// </summary>
    public string Use { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the local government area identifier
    /// </summary>
    public string LgAid { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last edited date of the assessment
    /// </summary>
    public DateTime? LastEdited { get; set; }

    /// <summary>
    /// Gets or sets the name of the last person to edit the assessment
    /// </summary>
    public string? LastEditedBy { get; set; }

    /// <summary>
    /// The date of the assessment
    /// </summary>
    public DateTime AssessmentDate { get; set; }

    /// <summary>
    /// Formatted string for display purposes
    /// </summary>
    public string FormattedString =>
        @$"
            Facility:({this.FacilityId}) {this.FacilityName} - {this.FacilityComponent}, 
            Use: {this.Use},  
            Template: {this.TemplateTitle}, 
            Date: {this.AssessmentDate:dd/MM/yyyy}".TrimEnd().TrimStart();
}