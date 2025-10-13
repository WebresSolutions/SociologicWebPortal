namespace Casimo.Server.Strings;

/// <summary>
/// Static class containing standardized error messages for bad request responses
/// Provides consistent error messaging across the application
/// </summary>
public static class BadRequestResponses
{
    /// <summary>
    /// Error message when a user cannot be found by the specified ID
    /// </summary>
    public const string UserNotFound = "Could not find user for the specified Id";
    
    /// <summary>
    /// Error message when an invalid user role is provided
    /// </summary>
    public const string InvalidUserRole = "An invalid role was supplied";
    
    /// <summary>
    /// Error message when user roles cannot be retrieved
    /// </summary>
    public const string FailedToGetUserRoles = "An error occured while getting the user roles";
    
    /// <summary>
    /// Error message for create user bad request scenarios
    /// </summary>
    public const string CreateUserBadRequest = "Create new user bad request";
    
    /// <summary>
    /// Error message when user creation fails
    /// </summary>
    public const string CreateUserFailed = "An error occured while creating the user";

    public const string MissingPermissionsToViewAssessments = "Missing permissions to view the assessment log";
}
