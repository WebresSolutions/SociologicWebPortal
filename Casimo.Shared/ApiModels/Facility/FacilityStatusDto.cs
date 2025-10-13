namespace Casimo.Shared.ApiModels.Facility;

/// <summary>
/// Data transfer object for facility status information
/// Immutable record containing status details for facility management
/// </summary>
/// <param name="StatusName">The human-readable name of the facility status</param>
/// <param name="Id">The unique identifier for the facility status</param>
public record FacilityStatusDto(string StatusName, int? Id);