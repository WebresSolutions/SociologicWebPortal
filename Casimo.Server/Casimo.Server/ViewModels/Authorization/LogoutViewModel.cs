using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Casimo.Server.ViewModels.Authorization;

/// <summary>
/// View model for logout operations
/// Contains request identification information for logout tracking
/// </summary>
public class LogoutViewModel
{
    /// <summary>
    /// Gets or sets the request identifier for logout tracking
    /// This property is excluded from model binding
    /// </summary>
    [BindNever]
    public string RequestId { get; set; } = string.Empty;
}
