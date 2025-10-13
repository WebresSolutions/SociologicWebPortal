using Microsoft.AspNetCore.Identity;

namespace Casimo.Data.IdentityData;

/// <summary>
/// Extended user model for the Casimo application
/// Inherits from IdentityUser to provide custom user properties for temporary user management
/// </summary>
public class ApplicationUser : IdentityUser
{
    /// <summary>
    /// Gets or sets a value indicating whether the user is a temporary user
    /// Temporary users have limited access and expiration dates
    /// </summary>
    public bool IsTemporaryUser { get; set; }

    /// <summary>
    /// Gets or sets the expiry date for temporary users
    /// Null for permanent users, contains expiration date for temporary users
    /// </summary>
    public DateTime? TemporaryUserExpiry { get; set; }
}
