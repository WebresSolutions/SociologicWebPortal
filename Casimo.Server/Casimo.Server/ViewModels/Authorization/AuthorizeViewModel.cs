using System.ComponentModel.DataAnnotations;

namespace Casimo.Server.ViewModels.Authorization;

/// <summary>
/// View model for OAuth authorization requests
/// Contains application and scope information for user consent
/// </summary>
public class AuthorizeViewModel
{
    /// <summary>
    /// Gets or sets the name of the application requesting authorization
    /// </summary>
    [Display(Name = "Application")]
    public string? ApplicationName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the scope of permissions being requested
    /// </summary>
    [Display(Name = "Scope")]
    public string? Scope { get; set; } = string.Empty;
}
