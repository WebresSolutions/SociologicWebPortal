namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for user information
/// Immutable record containing basic user details and authentication settings
/// </summary>
/// <param name="UserName">The username for the user account</param>
/// <param name="Email">The email address for the user account</param>
/// <param name="TwoFactorEnabled">Indicates whether two-factor authentication is enabled</param>
/// <param name="PhoneNumber">The phone number for the user account</param>
/// <param name="UserId">The unique identifier for the user</param>
/// <param name="Roles">The list of roles assigned to the user</param>
public record UserDto(string? UserName, string? Email, bool? TwoFactorEnabled, string? PhoneNumber, string UserId, List<string> Roles, DateTime? ExpirationDate);