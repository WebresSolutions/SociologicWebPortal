namespace Casimo.Shared.ApiModels.Responses;

/// <summary>
/// Data transfer object for saving section summaries and scores
/// Immutable record containing section summary data for assessment submissions
/// </summary>
/// <param name="SectionId">The unique identifier for the section</param>
/// <param name="SectionSummary">The summary text for the section</param>
/// <param name="SectionScore">The fitness for purpose score for the section</param>
public record SectionSummarySaveDto(int SectionId, string? SectionSummary, decimal SectionScore);