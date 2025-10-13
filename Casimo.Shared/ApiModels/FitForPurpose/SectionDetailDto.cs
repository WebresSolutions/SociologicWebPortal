namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for assessment section details
/// Contains section information and associated questions for fitness for purpose assessments
/// </summary>
public class SectionDetailDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the section
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// Gets or sets the sequential number of the section within the assessment
    /// </summary>
    public int SectionNumber { get; set; }

    /// <summary>
    /// Gets or sets the title or name of the section
    /// </summary>
    public string? SectionTitle { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the weight percentage for scoring purposes
    /// Represents the relative importance of this section in the overall assessment
    /// </summary>
    public decimal? WeightPercent { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a summary is required for this section
    /// </summary>
    public bool SummaryRequired { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this section contains general comments
    /// </summary>
    public bool IsGencomment { get; set; }

    /// <summary>
    /// If this is a comment but not general or asset specific
    /// </summary>
    public bool IsOtherComment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this section contains asset-specific comments
    /// </summary>
    public bool IsAssetComment { get; set; }

    /// <summary>
    /// The section summary
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// The FFP score for this section
    /// </summary>
    public decimal FFPScore { get; set; }

    /// <summary>
    /// The comment number
    /// </summary>
    public int CommentNumber { get; set; }

    /// <summary>
    /// Gets or sets the list of questions and responses within this section
    /// </summary>
    public List<QuestionResponseDetailDto> Questions { get; set; } = [];
}