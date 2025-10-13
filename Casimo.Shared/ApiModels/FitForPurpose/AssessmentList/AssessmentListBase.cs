namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Base class for assessment list data transfer objects
/// Contains common properties for creating and managing assessment lists
/// </summary>
public class AssessmentListBase
{
    /// <summary>
    /// Gets or sets a list of assessment log identifiers to include in the assessment list
    /// </summary>
    public List<int> AssessmentLogIds { get; set; } = [];

    /// <summary>
    /// Gets or sets the unique identifier for the assessment list
    /// </summary>
    public int AssessmentListId { get; set; }

    /// <summary>
    /// Gets or sets the name of the assessment list
    /// </summary>
    public string AssessmentListName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the assessment list
    /// </summary>
    public string AssessmentListDescription { get; set; } = string.Empty;
}