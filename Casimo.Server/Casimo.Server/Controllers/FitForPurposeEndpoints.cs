using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Constants;
using Casimo.Shared.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace Casimo.Server.Controllers;

/// <summary>
/// Static class containing endpoint configurations for fitness for purpose assessment operations
/// Maps HTTP endpoints to service methods for assessment management and retrieval
/// </summary>
public static class FitForPurposeEndpoints
{
    /// <summary>
    /// Adds fitness for purpose assessment endpoints to the application
    /// Configures all assessment-related API routes with proper authorization requirements
    /// </summary>
    /// <param name="app">The endpoint route builder to configure</param>
    public static void AddFitForPurposeEndpoints(this IEndpointRouteBuilder app)
    {
        RouteGroupBuilder fitForPurposeMappingGroup = app.MapGroup("api/SuitabilityAssessment");

        _ = fitForPurposeMappingGroup.MapGet("/All", async (
            [FromServices] IFitForPurposeService ffpService,
            HttpContext httpContext
        ) =>
        {
            Result<List<AssessmentListItemDto>> res = await ffpService.GetAssessmentList(httpContext);
            return EndpointsHelper.ProcessResult(res, "Failed to get the assessment list");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapGet("/{Id}", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromRoute] int id,
            HttpContext httpContext
        ) =>
        {
            Result<AssessmentLogDetailDto> res = await ffpService.GetAssessmentDetails(httpContext, id);
            return EndpointsHelper.ProcessResult(res, "Failed to get the assessment details");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapGet("UserAssessments/{userId}", async (
            [FromServices] IFitForPurposeService ffpService,
            HttpContext httpContext,
            [FromRoute] int userId
            ) =>
        {
            Result<List<UserAssessmentListDto>> res = await ffpService.GetAssessmentListsAssignedToUser(userId, httpContext);
            return EndpointsHelper.ProcessResult(res, "Failed to get user assessments");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapPost("/SaveQuestionResponse", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromBody] SaveQuestionResListDto req,
            HttpContext httpContext
        ) =>
        {
            if (req is null or { QuestionList: [] or null } or { LogId: 0 })
                return Results.BadRequest("Invalid request.");

            Result<AssessmentLogDetailDto> res = await ffpService.SaveQuestionResponses(httpContext, req);

            return EndpointsHelper.ProcessResult(res, "Failed to save question responses");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapGet("/AssessmentList", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromQuery] bool? showActiveOnly,
            HttpContext httpContext
        ) =>
        {
            Result<List<AssessmentsListDto>> res = await ffpService.GetListOfAssessmentLists(httpContext, showActiveOnly ?? true);

            return EndpointsHelper.ProcessResult(res, "Failed to get the assessment list");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapGet("/UsersAssignedToLog/{logID}", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromRoute] int logID,
            HttpContext httpContext
            ) =>
        {
            if (logID is <= 0)
                return Results.BadRequest($"Invalid request. The log Id cannot be {logID}");

            Result<UsersAssignedToAssessmentDto[]> res = await ffpService.GetUsersAssignedToAssessment(httpContext, logID);

            return EndpointsHelper.ProcessResult(res, "Failed to get users assigned to assessment");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapGet("/UsersAssignedToList/{listID}", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromRoute] int listID,
            HttpContext httpContext
            ) =>
        {
            if (listID is <= 0)
                return Results.BadRequest($"Invalid request. The log Id cannot be {listID}");

            Result<UsersAssignedToAssessmentDto[]> res = await ffpService.GetUsersAssignedToList(httpContext, listID);
            return EndpointsHelper.ProcessResult(res, "Failed to get users assigned to list");
        }).RequireAuthorization();

        _ = fitForPurposeMappingGroup.MapPost("/AssessmentList", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromBody] AssessmentListRequestDto req,
            HttpContext httpContext
            ) =>
        {
            if (req is null)
                return Results.BadRequest("Request cannot be null");

            if (req.AssessmentLogIds is null || req.AssessmentLogIds.Count == 0)
                return Results.BadRequest("Assessment log IDs list cannot be empty");

            if (req.AssessmentLogIds.Any(id => id <= 0))
                return Results.BadRequest("All assessment log IDs must be positive integers");

            if (string.IsNullOrWhiteSpace(req.AssessmentListName))
                return Results.BadRequest("Assessment list name cannot be empty");

            Result<AssessmentListResponseDto> res = await ffpService.SaveAssessmentList(httpContext, req);

            return EndpointsHelper.ProcessResult(res, "Failed to save assessment list");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser, RoleConstants.FullUser));

        _ = fitForPurposeMappingGroup.MapDelete("/AssessmentList/{id}", async (
            [FromServices] IFitForPurposeService ffpService,
            [FromRoute] int id
            ) =>
        {
            if (id is 0)
                return Results.BadRequest("Request cannot be null or 0");

            Result<bool> res = await ffpService.RemoveList(id);

            return EndpointsHelper.ProcessResult(res, "Failed to remove the user from the list");
        });
    }
}