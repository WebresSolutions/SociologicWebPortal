using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.ResponseModels;
using System.Security.Claims;

namespace Casimo.Server.Services.Interfaces;

public interface IUserManagerService
{
    /// <summary>
    /// Gets a list of all users with their roles
    /// </summary>
    /// <returns>A result containing a list of users or an error</returns>
    Task<Result<List<UserDto>>> GetUsers();

    /// <summary>
    /// Gets detailed information about a specific user
    /// </summary>
    /// <param name="userId">The user ID to retrieve details for</param>
    /// <returns>A result containing the user details or an error</returns>
    Task<Result<ManageUserDetailsDto>> GetUserDetails(string userId);

    /// <summary>
    /// Updates a user's details including roles
    /// </summary>
    /// <param name="userId">The user ID to update</param>
    /// <param name="request">The updated user details</param>
    /// <returns>A result containing the updated user details or an error</returns>
    Task<Result<ManageUserDetailsDto>> UpdateUserDetails(string userId, ManageUserDetailsDto request);

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="request">The user creation request</param>
    /// <returns>A result containing the created user details or an error</returns>
    Task<Result<ManageUserDetailsDto>> CreateUser(CreateUserDto request);

    /// <summary>
    /// Gets all available roles in the system
    /// </summary>
    /// <returns>A result containing a list of roles or an error</returns>
    Task<Result<IEnumerable<UserRolesDto>>> GetRoles();

    /// <summary>
    /// Invites users to an assessment list
    /// </summary>
    /// <param name="request">The invitation request</param>
    /// <returns>A result indicating success or failure</returns>
    Task<Result<bool>> InviteUser(UserAssessmentListInvite request);

    /// <summary>
    /// Removes a user from an assessment list
    /// </summary>
    /// <param name="userId">The user ID to remove</param>
    /// <param name="listId">The assessment list ID</param>
    /// <returns>A result indicating success or failure</returns>
    Task<Result<bool>> RemoveUserFromList(int userId, int listId);

    /// <summary>
    /// Imports the users from casimo into the identity database
    /// </summary>
    /// <returns></returns>
    Task<Result<int>> ImportUsersFromIdentityToCasimo();
}
