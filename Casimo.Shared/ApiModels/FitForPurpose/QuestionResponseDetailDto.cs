namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for detailed question responses in assessments
/// Contains question information, user responses, selections, and scoring data
/// </summary>
public class QuestionResponseDetailDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the question
    /// </summary>
    public int QuestionId { get; set; }

    /// <summary>
    /// Gets or sets the subsection identifier for organizing questions
    /// </summary>
    public string? Subsection { get; set; }

    /// <summary>
    /// Gets or sets the title or heading of the question
    /// </summary>
    public string? QuestionTitle { get; set; }

    /// <summary>
    /// Gets or sets the full text content of the question
    /// </summary>
    public string? QuestionText { get; set; }

    /// <summary>
    /// Gets or sets helpful comments or guidance for the question
    /// </summary>
    public string? HelpComments { get; set; }

    /// <summary>
    /// Gets or sets the response log identifier from TblFfpasstQuestionResponses
    /// </summary>
    public int ResponseLogId { get; set; }

    /// <summary>
    /// Gets or sets the first response text from the user
    /// Typically contains the "FFP now and future" response
    /// </summary>
    public string? ResponseText1 { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier for the first selection choice
    /// </summary>
    public int? Selection1Id { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the second selection choice
    /// </summary>
    public int? Selection2Id { get; set; }

    /// <summary>
    /// Gets or sets the second response text from the user
    /// Typically contains the "Suggested Solutions" response
    /// </summary>
    public string? ResponseText2 { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the score for the first response
    /// </summary>
    public int? Score1 { get; set; }

    /// <summary>
    /// Gets or sets the score for the second response
    /// </summary>
    public int? Score2 { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the selected option if applicable
    /// </summary>
    public int? SelectedOptionId { get; set; }

    /// <summary>
    /// Gets or sets the text of the selected option for display purposes
    /// </summary>
    public string? SelectedOptionText { get; set; }
}