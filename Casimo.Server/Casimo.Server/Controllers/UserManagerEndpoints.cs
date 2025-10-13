using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Constants;
using Casimo.Shared.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace Casimo.Server.Controllers;

/// <summary>
/// Static class containing endpoint configurations for user management operations
/// Maps HTTP endpoints to service methods for user CRUD operations and management
/// </summary>
public static class UserManagerEndpoints
{
    /// <summary>
    /// Adds user management endpoints to the application
    /// Configures all user-related API routes with proper authorization requirements
    /// </summary>
    /// <param name="app">The endpoint route builder to configure</param>
    public static void AddUserManagerEndpoints(this IEndpointRouteBuilder app)
    {
        RouteGroupBuilder userManagerGroup = app.MapGroup("api/UserManager");

        // Get all users (AdminUser only)
        userManagerGroup.MapGet("/Users", async (
            [FromServices] IUserManagerService userManagerService
        ) =>
        {
            Result<List<UserDto>> res = await userManagerService.GetUsers();
            return EndpointsHelper.ProcessResult(res, "Failed to get the list of users");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));

        // Get user details by ID (Admin only)
        userManagerGroup.MapGet("/User/{userId}", async (
            [FromServices] IUserManagerService userManagerService,
            [FromRoute] string userId
        ) =>
        {
            Result<ManageUserDetailsDto> res = await userManagerService.GetUserDetails(userId);
            return EndpointsHelper.ProcessResult(res, "Failed to get the user details");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));

        // Update user details (AdminUser only)
        userManagerGroup.MapPut("/User/{userId}", async (
            [FromServices] IUserManagerService userManagerService,
            [FromRoute] string userId,
            [FromBody] ManageUserDetailsDto req
        ) =>
        {
            Result<ManageUserDetailsDto> res = await userManagerService.UpdateUserDetails(userId, req);
            return EndpointsHelper.ProcessResult(res, "Failed to update the user details");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));

        // Create new user (AdminUser only)
        userManagerGroup.MapPost("/User", async (
            [FromServices] IUserManagerService userManagerService,
            [FromBody] CreateUserDto req
        ) =>
        {
            if (req == null)
                return Results.BadRequest("Invalid request");

            Result<ManageUserDetailsDto> res = await userManagerService.CreateUser(req);
            return EndpointsHelper.ProcessResult(res, "Failed to create the new user");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));

        // Get all roles (AdminUser only)
        userManagerGroup.MapGet("/Roles", async (
            [FromServices] IUserManagerService userManagerService
        ) =>
        {
            Result<IEnumerable<UserRolesDto>> res = await userManagerService.GetRoles();
            return EndpointsHelper.ProcessResult(res, "Failed to get all roles.");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));

        // Invite user to assessment list
        userManagerGroup.MapPost("/InviteUserToAssessmentList", async (
            [FromServices] IUserManagerService userManagerService,
            [FromBody] UserAssessmentListInvite req
        ) =>
        {
            Result<bool> res = await userManagerService.InviteUser(req);
            return EndpointsHelper.ProcessResult(res, "Failed to invite user to assessment list.");
        }).RequireAuthorization();

        // Remove user from assessment list
        userManagerGroup.MapDelete("/RemoveUserFromList/{userId}/{listId}", async (
            [FromServices] IUserManagerService userManagerService,
            [FromRoute] int userId,
            [FromRoute] int listId
        ) =>
        {
            Result<bool> res = await userManagerService.RemoveUserFromList(userId, listId);
            return EndpointsHelper.ProcessResult(res, "Failed to remove the user from the list");
        }).RequireAuthorization();

        userManagerGroup.MapPost("/ImportUsers", async (
            [FromServices] IUserManagerService userManagerService
            ) =>
        {
            Result<int> res = await userManagerService.ImportUsersFromIdentityToCasimo();
            return EndpointsHelper.ProcessResult(res, "Failed to import users");
        }).RequireAuthorization(policy => policy.RequireRole(RoleConstants.AdminUser));
    }
}
