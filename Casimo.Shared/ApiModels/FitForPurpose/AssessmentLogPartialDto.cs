namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for partial assessment log information
/// Immutable record containing basic assessment details for list displays
/// </summary>
/// <param name="LogId">The assessment log identifier</param>
/// <param name="LogName">The name or title of the assessment log</param>
/// <param name="FacilityName">The name of the facility being assessed</param>
/// <param name="facilityId">The unique identifier for the facility</param>
public record AssessmentLogPartialDto(int LogId, string LogName, string FacilityName, int facilityId, int statusId, string statusName);