using Casimo.Shared.ApiModels.FitForPurpose;

namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for user assessment list assignments
/// Contains assessment list information and associated assessments assigned to a user
/// </summary>
public class UserAssessmentListDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the assessment list
    /// </summary>
    public int ListId { get; set; }

    /// <summary>
    /// Gets or sets the optional name of the assessment list
    /// </summary>
    public string? AssessmentListName { get; set; }

    /// <summary>
    /// Gets or sets the optional description of the assessment list
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the list of assigned user assessments
    /// Contains assessment items that the user is responsible for
    /// </summary>
    public List<AssessmentListItemDto> AssessmentList { get; set; } = [];
}