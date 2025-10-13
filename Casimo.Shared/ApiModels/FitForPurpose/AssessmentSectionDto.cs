namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for assessment sections
/// Contains section structure and associated template questions for assessments
/// </summary>
public class AssessmentSectionDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the section
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// Gets or sets the number of the section in the template
    /// Used for ordering sections within the assessment
    /// </summary>
    public int SectionNumber { get; set; }

    /// <summary>
    /// Gets or sets the title or description of the section
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether a summary is required for this section
    /// </summary>
    public bool SummaryRequired { get; set; }

    /// <summary>
    /// Gets or sets the weight of the section
    /// Used to determine the section's importance or contribution to the overall assessment score
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// Gets or sets the list of template questions contained within this section
    /// </summary>
    public List<TemplateQuestionDto> TemplateQuestions { get; set; } = [];
}