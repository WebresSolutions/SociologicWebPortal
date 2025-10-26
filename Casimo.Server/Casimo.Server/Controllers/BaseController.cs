using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Casimo.Server.Controllers;

/// <summary>
/// Base controller class providing common functionality for all API controllers
/// Contains utility methods for standardized error responses
/// </summary>
public class BaseController : ControllerBase
{
    /// <summary>
    /// Wraps server errors in a standardized response format
    /// Returns an HTTP status code with a user-friendly error message
    /// </summary>
    /// <param name="usrErrMsg">User-friendly error message to display</param>
    /// <param name="statusCode">HTTP status code to return</param>
    /// <returns>ActionResult with the specified status code and error message</returns>
    protected ActionResult WrapServerError(string usrErrMsg, HttpStatusCode statusCode)
    {
        return StatusCode((int)statusCode, usrErrMsg);
    }
}
