namespace Casimo.Shared.ApiModels;

/// <summary>
/// Data transfer object for user role information
/// Immutable record containing role details for user management
/// </summary>
/// <param name="Name">The name of the role</param>
/// <param name="Id">The unique identifier for the role</param>
public record UserRolesDto(string? Name, string Id);