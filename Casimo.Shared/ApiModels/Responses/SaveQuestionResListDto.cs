using Casimo.Shared.Enums;

namespace Casimo.Shared.ApiModels.Responses;

/// <summary>
/// Data transfer object for saving multiple question responses
/// Contains a collection of question responses and submission metadata
/// </summary>
public class SaveQuestionResListDto
{
    /// <summary>
    /// Gets or sets the assessment log identifier
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Gets or sets the assessment status for the submission
    /// Indicates the current state of the assessment (e.g., InProgress, Review, Completed)
    /// </summary>
    public AssessmentStatusEnum? SubmissionType { get; set; }

    /// <summary>
    /// Gets or sets the list of question responses to save
    /// Contains individual question response data for the assessment
    /// </summary>
    public List<SaveQuestionResponseDto> QuestionList { get; set; } = [];

    /// <summary>
    /// The section summary to save. This should only be saved by full users
    /// </summary>
    public List<SectionSummarySaveDto>? SectionSummaryList { get; set; }
}