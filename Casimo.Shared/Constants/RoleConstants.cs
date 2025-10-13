namespace Casimo.Shared.Constants;

/// <summary>
/// Constants defining the available user roles in the system
/// Used for role-based access control and authorization
/// </summary>
public static class RoleConstants
{
    /// <summary>
    /// Administrator role with full system access
    /// </summary>
    public const string AdminUser = "AdminUser";

    /// <summary>
    /// Council user role with limited administrative access
    /// </summary>
    public const string FullUser = "FullUser";

    /// <summary>
    /// Temporary user role with restricted access
    /// </summary>
    public const string TemporaryUser = "TemporaryUser";
}

public static class PolicyConstants
{
    /// <summary>
    /// Administrator role with full system access
    /// </summary>
    public const string AdminOnly = "AdminPolicy";

    /// <summary>
    /// Full user policy
    /// </summary>
    public const string FullUserOnly = "FullUserPolicy";

    /// <summary>
    /// Temporary user role policy
    /// </summary>
    public const string TemporaryUserOnly = "TemporaryUserPolicy";
}