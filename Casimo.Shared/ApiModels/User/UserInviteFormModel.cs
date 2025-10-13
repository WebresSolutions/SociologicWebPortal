using System.ComponentModel.DataAnnotations;

namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Form model for inviting users to assessment lists
/// Contains validation attributes for email input
/// </summary>
public class UserInviteFormModel
{
    /// <summary>
    /// Gets or sets the email address for the user invitation
    /// Must be a valid email format
    /// </summary>
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string? Email { get; set; }
}