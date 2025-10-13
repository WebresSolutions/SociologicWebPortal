using System;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Routing;

namespace Casimo.Server.Helpers;

/// <summary>
/// Action method selector attribute that requires a specific form value to be present
/// Used to conditionally select action methods based on form data availability
/// </summary>
public sealed class FormValueRequiredAttribute : ActionMethodSelectorAttribute
{
    /// <summary>
    /// The name of the form value that must be present
    /// </summary>
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of the FormValueRequiredAttribute
    /// </summary>
    /// <param name="name">The name of the form value that must be present</param>
    public FormValueRequiredAttribute(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Determines whether the action method is valid for the current request
    /// Checks if the required form value is present in the request
    /// </summary>
    /// <param name="context">The route context containing request information</param>
    /// <param name="action">The action descriptor being evaluated</param>
    /// <returns>True if the action method is valid for the request, false otherwise</returns>
    public override bool IsValidForRequest(RouteContext context, ActionDescriptor action)
    {
        if (string.Equals(context.HttpContext.Request.Method, "GET", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(context.HttpContext.Request.Method, "HEAD", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(context.HttpContext.Request.Method, "DELETE", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(context.HttpContext.Request.Method, "TRACE", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        if (string.IsNullOrEmpty(context.HttpContext.Request.ContentType))
        {
            return false;
        }

        if (!context.HttpContext.Request.ContentType.StartsWith("application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        return !string.IsNullOrEmpty(context.HttpContext.Request.Form[_name]);
    }
}
