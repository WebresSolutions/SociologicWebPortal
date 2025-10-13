namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for assessment template questions
/// Contains question structure and content for assessment templates
/// </summary>
public class TemplateQuestionDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the question
    /// </summary>
    public int QuestionID { get; set; }

    /// <summary>
    /// Gets or sets the section identifier that contains this question
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// Gets or sets the order of the question within its section
    /// </summary>
    public int QuestionOrder { get; set; }

    /// <summary>
    /// Gets or sets the subsection identifier for organizing questions
    /// </summary>
    public string SubSection { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the full text content of the question
    /// </summary>
    public string QuestionText { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the title or heading of the question
    /// </summary>
    public string QuestionTitle { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets optional help text or guidance for the question
    /// </summary>
    public string? HelpComments { get; set; }

    /// <summary>
    /// Gets the combined subsection identifier and number for display purposes
    /// </summary>
    public string SubsectionAndNumber => $"{SectionId}{SubSection}";
}