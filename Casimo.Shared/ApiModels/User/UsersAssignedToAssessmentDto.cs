namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for users assigned to assessments
/// Immutable record containing user assignment information for assessments
/// </summary>
/// <param name="Username">The username of the assigned user</param>
/// <param name="RoleName">The role name assigned to the user</param>
/// <param name="UserId">The unique identifier for the user</param>
public record UsersAssignedToAssessmentDto(string Username, string RoleName, string UserId, int casimoUserId);