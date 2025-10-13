namespace Casimo.Shared.ApiModels.Responses;

/// <summary>
/// Data transfer object for saving question responses
/// Contains question response data for assessment submissions
/// </summary>
public class SaveQuestionResponseDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the question
    /// </summary>
    public int QuestionId { get; set; }

    /// <summary>
    /// Gets or sets the first optional response text
    /// Typically contains the "FFP now and future" response
    /// </summary>
    public string? Response1 { get; set; }

    /// <summary>
    /// Gets or sets the second optional response text
    /// Typically contains the "Suggested Solutions" response
    /// </summary>
    public string? Response2 { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the first selection choice
    /// </summary>
    public int? SelectionId1 { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the second selection choice
    /// </summary>
    public int? SelectionId2 { get; set; }
}