namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for managing user details and role assignments
/// Contains comprehensive user information for editing and administration
/// </summary>
public class ManageUserDetailsDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the user
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets the username for the user account
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// Gets or sets the email address for the user account
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the phone number for the user account
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The date which access will expire, or null if it does not expire
    /// </summary>
    public DateTime? ExpiryDate { get; set; }

    /// <summary>
    /// Gets or sets the list of roles assigned to the user
    /// </summary>
    public List<string> Roles { get; set; } = [];

    /// <summary>
    /// Gets or sets the list of claims associated with the user
    /// </summary>
    public List<string> Claims { get; set; } = [];

    /// <summary>
    /// Initializes a new instance of the ManageUserDetailsDto class with specified values
    /// </summary>
    /// <param name="userId">The unique identifier for the user</param>
    /// <param name="userName">The username for the user account</param>
    /// <param name="email">The email address for the user account</param>
    /// <param name="phoneNumber">The phone number for the user account</param>
    /// <param name="roles">The list of roles assigned to the user</param>
    /// <param name="claims">The list of claims associated with the user</param>
    public ManageUserDetailsDto(
        string userId,
        string? userName,
        string? email,
        string? phoneNumber,
        List<string> roles,
        List<string> claims,
        DateTime? expDate)
    {
        UserId = userId;
        UserName = userName;
        Email = email;
        PhoneNumber = phoneNumber;
        Roles = roles ?? [];
        Claims = claims ?? [];
        ExpiryDate = expDate;
    }

    /// <summary>
    /// Initializes a new instance of the ManageUserDetailsDto class
    /// Parameterless constructor for serialization purposes
    /// </summary>
    public ManageUserDetailsDto()
    {
        UserId = string.Empty;
        UserName = null;
        Email = null;
        Roles = [];
        Claims = [];
        ExpiryDate = null;
    }
}