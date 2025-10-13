using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Server.ApiData;
using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Constants;
using Casimo.Shared.Helpers;
using Casimo.Shared.ResponseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Quartz.Util;
using System.Security.Claims;

namespace Casimo.Server.Services.Instances;

public class UserManagerService(
    UserManager<ApplicationUser> _userManager,
    AuthDBContext _authDbContext,
    ILogger<UserManagerService> _logger,
    RoleManager<IdentityRole> _roleManager,
    IEmailSender _emailSender,
    CasimoDbContext _casimoDB,
    IOptions<EmailOptions> _emailSettings
) : IUserManagerService
{
    /// <summary>
    /// Gets a list of all users with their roles
    /// </summary>
    /// <returns>A result containing a list of users or an error</returns>
    public async Task<Result<List<UserDto>>> GetUsers()
    {
        Result<List<UserDto>> res = new();
        try
        {
            List<UserDto> users = await (
                from user in _authDbContext.Users
                join userRole in _authDbContext.UserRoles on user.Id equals userRole.UserId into userRoles
                from ur in userRoles.DefaultIfEmpty()
                join role in _authDbContext.Roles on ur.RoleId equals role.Id into roles
                from r in roles.DefaultIfEmpty()
                group r by user into grouped
                select new UserDto(
                    grouped.Key.UserName,
                    grouped.Key.Email,
                    grouped.Key.TwoFactorEnabled,
                    grouped.Key.PhoneNumber,
                    grouped.Key.Id,
                    grouped.Where(role => role != null).Select(role => role.Name ?? "").ToList(),
                    grouped.Key.TemporaryUserExpiry
                )).ToListAsync();

            res.Value = users;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to retrieve users";
            return res;
        }
    }

    /// <summary>
    /// Gets detailed information about a specific user
    /// </summary>
    /// <param name="userId">The user ID to retrieve details for</param>
    /// <returns>A result containing the user details or an error</returns>
    public async Task<Result<ManageUserDetailsDto>> GetUserDetails(string userId)
    {
        Result<ManageUserDetailsDto> res = new();
        try
        {
            if (userId.IsNullOrWhiteSpace() || await _userManager.FindByIdAsync(userId) is not ApplicationUser user)
            {
                res.Error = ErrorType.BadRequest;
                res.ErrorDescription = "User not found";
                return res;
            }

            IList<string> roles = await _userManager.GetRolesAsync(user);
            IList<Claim> claims = await _userManager.GetClaimsAsync(user);
            IEnumerable<string> claimsName = claims.Select(x => x.Value);

            ManageUserDetailsDto userDetails = new(userId, user.UserName, user.Email, user.PhoneNumber, [.. roles], [.. claimsName], user.TemporaryUserExpiry);
            res.Value = userDetails;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to retrieve user details";
            return res;
        }
    }

    /// <summary>
    /// Updates a user's details including roles
    /// </summary>
    /// <param name="userId">The user ID to update</param>
    /// <param name="request">The updated user details</param>
    /// <returns>A result containing the updated user details or an error</returns>
    public async Task<Result<ManageUserDetailsDto>> UpdateUserDetails(string userId, ManageUserDetailsDto request)
    {
        Result<ManageUserDetailsDto> res = new();
        try
        {
            // Get the user 
            ApplicationUser? user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                res.Error = ErrorType.BadRequest;
                res.ErrorDescription = "User not found";
                return res;
            }

            // Assure that all of the roles actually exist 
            foreach (string? role in request.Roles)
            {
                if (await _roleManager.FindByNameAsync(role) is null)
                {
                    res.Error = ErrorType.BadRequest;
                    res.ErrorDescription = "Role not found";
                    return res;
                }
            }

            // Update the user details
            user.UserName = request.UserName?.Trim();
            user.Email = request.Email?.Trim();
            user.PhoneNumber = request.PhoneNumber?.Trim();
            user.TemporaryUserExpiry = request.Roles[0] is RoleConstants.TemporaryUser ? request.ExpiryDate : null;
            user.IsTemporaryUser = request.Roles[0] is RoleConstants.TemporaryUser;

            // Get the current list of roles
            IList<string> roles = await _userManager.GetRolesAsync(user);

            // Remove all of the old roles
            _ = await _userManager.RemoveFromRolesAsync(user, roles);

            // Add the user to the new roles
            _ = await _userManager.AddToRolesAsync(user, request.Roles);
            if (request.Roles.Count == 1 && request.Roles.First() == RoleConstants.TemporaryUser)
                user.IsTemporaryUser = true;
            TblUser? tblUser = await _casimoDB.TblUsers.FirstOrDefaultAsync(x => x.IdentityId == user.Id);
            if (tblUser is null)
            {
                res.Error = ErrorType.InternalError;
                res.ErrorDescription = "Could not find the linked user in the casimo database";
                _logger.LogError(message: $"Method: {nameof(UpdateUserDetails)} failed to find the associated table user");
                return res;
            }
            tblUser.IsTempUser = request.Roles[0] is RoleConstants.TemporaryUser;

            await _casimoDB.SaveChangesAsync();

            // Update the user details
            IdentityResult updateUserRes = await _userManager.UpdateAsync(user);
            // Update the user
            IList<Claim> claims = await _userManager.GetClaimsAsync(user);
            IEnumerable<string> claimsName = claims.Select(x => x.Value);
            ManageUserDetailsDto updatedUser = new(userId, user.UserName, user.Email, user.PhoneNumber, [.. roles], [.. claimsName], user.TemporaryUserExpiry);
            res.Value = updatedUser;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to update user details";
            return res;
        }
    }

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="request">The user creation request</param>
    /// <returns>A result containing the created user details or an error</returns>
    public async Task<Result<ManageUserDetailsDto>> CreateUser(CreateUserDto request)
    {
        Result<ManageUserDetailsDto> res = new();
        try
        {
            // Ensure that the role exists
            if (await _roleManager.FindByNameAsync(request.Role) is null)
            {
                res.Error = ErrorType.BadRequest;
                res.ErrorDescription = "Role not found";
                return res;
            }

            ApplicationUser user = new()
            {
                UserName = request.UserName,
                Email = request.Email,
                EmailConfirmed = false,
                PhoneNumber = request.PhoneNumber
            };

            // Create the user
            IdentityResult createUserRes = await _userManager.CreateAsync(user);
            if (!createUserRes.Succeeded)
            {
                res.Error = ErrorType.InternalError;
                res.ErrorDescription = "Failed to create the user";
                return res;
            }

            // Add the role to the user
            _ = await _userManager.AddToRoleAsync(user, request.Role);

            // Get the new user including the id to ensure that the user exists
            ApplicationUser? createdUser = await _userManager.FindByNameAsync(user.UserName)
                ?? throw new Exception("Could not find the newly created user");

            // Get the claims and roles
            IList<string> roles = await _userManager.GetRolesAsync(createdUser);
            IList<Claim> claims = await _userManager.GetClaimsAsync(createdUser);
            IEnumerable<string> claimsName = claims.Select(x => x.Value);

            // Create the dto and return the results
            ManageUserDetailsDto result = new(createdUser.UserName!, user.UserName, user.Email, user.PhoneNumber, [.. roles], [.. claimsName], user.TemporaryUserExpiry);
            res.Value = result;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Create user failed";
            return res;
        }
    }

    /// <summary>
    /// Gets all available roles in the system
    /// </summary>
    /// <returns>A result containing a list of roles or an error</returns>
    public async Task<Result<IEnumerable<UserRolesDto>>> GetRoles()
    {
        Result<IEnumerable<UserRolesDto>> res = new();
        try
        {
            List<UserRolesDto> roles = await _roleManager.Roles.Select(x => new UserRolesDto(x.Name, x.Id)).ToListAsync();
            res.Value = roles;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to get user roles";
            return res;
        }
    }

    /// <summary>
    /// Invites users to an assessment list
    /// </summary>
    /// <param name="request">The invitation request</param>
    /// <returns>A result indicating success or failure</returns>
    public async Task<Result<bool>> InviteUser(UserAssessmentListInvite request)
    {
        Result<bool> res = new();
        try
        {
            // Find the assessment list
            if (await _casimoDB.TblAssessmentLists.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.ListId) is not TblAssessmentList assessmentList)
            {
                res.Error = ErrorType.BadRequest;
                res.ErrorDescription = "Invalid assessment list ID";
                return res;
            }

            if (request is null or { Emails: null or [] } or { ListId: 0 })
            {
                res.Error = ErrorType.BadRequest;
                res.ErrorDescription = "Invalid user invite request";
                return res;
            }

            foreach (string email in request.Emails)
            {
                if (!Validation.IsValidEmail(email))
                {
                    res.Error = ErrorType.BadRequest;
                    res.ErrorDescription = "Invalid email";
                    return res;
                }
            }

            List<TblUser> users = [];

            foreach (string userEmail in request.Emails)
            {
                (TblUser?, string?) result = await CreateAndUpdateUser(userEmail);
                if (result.Item2 is not null)
                {
                    res.Error = ErrorType.InternalError;
                    res.ErrorDescription = result.Item2;
                    return res;
                }

                if (result.Item1 is null)
                {
                    res.Error = ErrorType.InternalError;
                    res.ErrorDescription = "An error occurred while saving the user to the database";
                    return res;
                }

                users.Add(result.Item1);
            }

            List<TblUserAssignedAssessmentList> userListItemsToAdd = [];
            List<Task> emailTasks = [];

            foreach (TblUser user in users)
            {
                if (await _casimoDB.TblUserAssignedAssessmentLists.AnyAsync(x => x.UserId == user.UserId && x.ListId == assessmentList.Id))
                    continue;

                // Create the user list item
                TblUserAssignedAssessmentList tblUserAssignedAssessmentList = new()
                {
                    UserId = user.UserId,
                    ListId = request.ListId,
                    DateAssigned = DateTime.UtcNow
                };

                userListItemsToAdd.Add(tblUserAssignedAssessmentList);

                if (_emailSettings.Value.SendEmails)
                {
                    emailTasks.Add(
                        _emailSender.SendEmailAsync(
                        user.Email!,
                        "Invited to complete casimo assessments",
                        $"Hi, you have been invited to complete a casimo assessment. " +
                        $"Please use the following link to view your assigned assessments: <a href='{_emailSettings.Value.LoginUrl}'>{_emailSettings.Value.LoginUrl}</a>")
                        );
                }
            }

            // Send the email as a parallel task to increase performance
            await Task.WhenAll(emailTasks);

            if (userListItemsToAdd.Count > 0)
            {
                await _casimoDB.TblUserAssignedAssessmentLists.AddRangeAsync(userListItemsToAdd);
            }

            await _casimoDB.SaveChangesAsync();

            res.Value = true;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to invite users";
            return res;
        }
    }

    /// <summary>
    /// Removes a user from an assessment list
    /// </summary>
    /// <param name="userId">The user ID to remove</param>
    /// <param name="listId">The assessment list ID</param>
    /// <returns>A result indicating success or failure</returns>
    public async Task<Result<bool>> RemoveUserFromList(int userId, int listId)
    {
        Result<bool> res = new();
        try
        {
            await _casimoDB.TblUserAssignedAssessmentLists
                .Where(x => x.UserId == userId && x.ListId == listId)
                .ExecuteDeleteAsync();

            res.Value = true;
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message);
            res.Error = ErrorType.InternalError;
            res.ErrorDescription = "Failed to remove user from list";
            return res;
        }
    }

    /// <summary>
    /// Imports users from the Identity database to the Casimo database
    /// Creates Identity users for existing Casimo users that don't have Identity records
    /// </summary>
    /// <returns>A result containing the number of users imported or an error</returns>
    public async Task<Result<int>> ImportUsersFromIdentityToCasimo()
    {
        Result<int> res = new();
        try
        {
            // Get all of the casimo users
            TblUser[] usersToUpdate = await _casimoDB.TblUsers.Where(x => x.IdentityId == null && x.IsActive == true).ToArrayAsync();
            // Get all of the identity users
            ApplicationUser[] identityUsers = await _authDbContext.Users.ToArrayAsync();

            List<ApplicationUser> newUsers = [];
            // Find all of the users not created in the identity database
            foreach (TblUser user in usersToUpdate)
            {
                ApplicationUser application = new()
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = false,
                    IsTemporaryUser = false,
                    TemporaryUserExpiry = null,
                    LockoutEnabled = false
                };
                newUsers.Add(application);
            }

            // Add the new application users to the database
            await _authDbContext.Users.AddRangeAsync(newUsers);
            await _authDbContext.SaveChangesAsync();

            // Update the application users
            foreach (TblUser casimoUser in usersToUpdate)
            {
                // Find the tbl user
                ApplicationUser identityUser = newUsers.First(x => x.Email == casimoUser.Email);
                casimoUser.IdentityId = identityUser.Id;
            }

            await _casimoDB.SaveChangesAsync();

            return res;
        }
        catch (Exception)
        {
            return res;
        }
    }

    /// <summary>
    /// Creates or updates a user for assessment list invitations
    /// </summary>
    /// <param name="email">The email address for the user</param>
    /// <returns>A tuple containing the user and any error message</returns>
    private async Task<(TblUser?, string?)> CreateAndUpdateUser(string email)
    {
        try
        {
            // Check if the user exists in the database
            ApplicationUser? existingUser = await _userManager.FindByEmailAsync(email);

            if (existingUser is null)
            {
                // All users invited this way will be temporary
                ApplicationUser user = new()
                {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = false,
                    IsTemporaryUser = true,
                    TemporaryUserExpiry = DateTime.UtcNow.AddDays(14),
                };

                IdentityResult createUserRes = await _userManager.CreateAsync(user);
                if (!createUserRes.Succeeded)
                    return (null, "Failed to create the user");

                _ = await _userManager.AddToRoleAsync(user, RoleConstants.TemporaryUser);

                // Get the new user including the id to ensure that the user exists
                ApplicationUser? createdUser = await _userManager.FindByNameAsync(user.UserName)
                    ?? throw new Exception("Could not find the newly created user");

                existingUser = createdUser;
            }
            else
            {
                existingUser.TemporaryUserExpiry = DateTime.UtcNow.AddDays(14);
                await _userManager.UpdateAsync(existingUser);
            }

            // Create or find the application user in the database
            TblUser tblUser = await DbHelpers.AddApplicationUserToCasimoDb(existingUser, _casimoDB);

            return (tblUser, null);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return (null, ex.Message);
        }
    }
}
