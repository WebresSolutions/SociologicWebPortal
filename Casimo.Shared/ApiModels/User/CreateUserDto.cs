using System.ComponentModel.DataAnnotations;

namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for creating new users in the system
/// Contains all required information for user account creation
/// </summary>
public class CreateUserDto
{
    /// <summary>
    /// Gets or sets the username for the new user account
    /// Must be unique within the system
    /// </summary>
    [Required]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets the email address for the new user account
    /// Must be a valid email format and unique within the system
    /// </summary>
    [Required]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the role assigned to the new user
    /// Determines the user's permissions and access levels
    /// </summary>
    [Required]
    public string Role { get; set; }

    /// <summary>
    /// Gets or sets the optional phone number for the new user
    /// </summary>
    public string? PhoneNumber { get; set; }
}