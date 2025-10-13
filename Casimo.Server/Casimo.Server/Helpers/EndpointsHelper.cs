﻿using Casimo.Shared.ResponseModels;

namespace Casimo.Server.Helpers;

/// <summary>
/// Helper class for processing API endpoint results
/// Provides utility methods for converting service results to HTTP responses
/// </summary>
public static class EndpointsHelper
{
    /// <summary>
    /// Processes a service result and converts it to an appropriate HTTP response
    /// Maps different error types to their corresponding HTTP status codes
    /// </summary>
    /// <typeparam name="T">The type of data in the result</typeparam>
    /// <param name="res">The service result to process</param>
    /// <param name="internalErrString">Custom error message for internal server errors</param>
    /// <returns>An HTTP result appropriate for the service result</returns>
    public static IResult ProcessResult<T>(Result<T> res, string? internalErrString = "Internal server error occured")
    {
        if (res.Error is null)
            return Results.Ok(res.Value);

        if (res.Error is ErrorType.NotFound)
            return Results.NotFound(res.Error);

        if (res.Error is ErrorType.BadRequest)
            return Results.BadRequest(res.Error);

        return res.Error is ErrorType.Unauthorized
            ? Results.Unauthorized()
            : Results.InternalServerError(res.ErrorDescription ?? internalErrString);
    }

}
