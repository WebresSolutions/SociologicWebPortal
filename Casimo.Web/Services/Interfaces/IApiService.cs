using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;

namespace Casimo.Web.Services.Interfaces;

public interface IApiService
{
    /// <summary>
    /// Gets all application users
    /// </summary>
    /// <returns>A result containing a list of user DTOs or an error if the operation fails</returns>
    Task<Result<List<UserDto>>> GetAllUsers();

    /// <summary>
    /// Get details for a specific user
    /// </summary>
    /// <param name="userId">The User Id</param>
    /// <returns>A result containing the user details or an error if not found</returns>
    Task<Result<ManageUserDetailsDto>> GetUserDetails(string userId);

    /// <summary>
    /// Saves a user details and roles
    /// </summary>
    /// <param name="userId">The User Id</param>
    /// <param name="req">The Request to save</param>
    /// <returns>A result containing the updated user details or an error if the operation fails</returns>
    Task<Result<ManageUserDetailsDto>> SaveUserDetails(string userId, ManageUserDetailsDto req);

    /// <summary>
    /// Get the user roles
    /// </summary>
    /// <returns>A result containing a collection of user roles or an error if the operation fails</returns>
    Task<Result<List<UserRolesDto>>> GetUserRoles();

    /// <summary>
    /// Gets all facilities with pagination and optional name filtering
    /// </summary>
    /// <param name="pageSize">The number of facilities to return per page</param>
    /// <param name="pageNumber">The page number to retrieve</param>
    /// <param name="nameFilter">Optional filter to search facilities by name</param>
    /// <returns>A result containing a paged response of facilities or an error if the operation fails</returns>
    Task<Result<PagedResponse<FacilityListItemDto>>> GetAllFacilities(int pageSize, int pageNumber, string? nameFilter, string? orderby, SortDirectionEnum order);

    /// <summary>
    /// Get a specific facility by its ID along with its subspaces and assessment logs
    /// </summary>
    /// <param name="facilityId">The facility ID to retrieve</param>
    /// <returns>A result containing the facility details or an error if not found</returns>
    Task<Result<FacilityDTO>> GetFacility(int facilityId);

    /// <summary>
    /// Save the details of the facilty
    /// </summary>
    /// <param name="req">Contains facility details</param>
    /// <returns>The facility</returns>
    Task<Result<FacilityDTO>> SaveFacility(FacilityDetailsDto req);

    /// <summary>
    /// Gets an assessment based on the assessment ID
    /// </summary>
    /// <param name="assessmentId">The assessment ID to retrieve</param>
    /// <returns>A result containing the assessment details or an error if not found</returns>
    Task<Result<AssessmentLogDetailDto>> GetAssessment(int assessmentId);

    /// <summary>
    /// Saves a batch of question responses for an assessment
    /// </summary>
    /// <param name="req">The request containing the assessment data to save</param>
    /// <returns>A result containing the saved question response details or an error if the operation fails</returns>
    Task<Result<AssessmentLogDetailDto>> SaveQuestions(SaveQuestionResListDto req);

    /// <summary>
    /// Gets user assignments for a specific user or the current user
    /// </summary>
    /// <param name="userId">The user ID to get assignments for (0 for current user)</param>
    /// <returns>A result containing the user's assessment assignments or an error if the operation fails</returns>
    Task<Result<List<UserAssessmentListDto>>> GetUserAssignments(int userId = 0);

    /// <summary>
    /// Gets a list of assessments
    /// </summary>
    /// <returns>A result containing a list of assessments or an error if the operation fails</returns>
    Task<Result<List<AssessmentListItemDto>>> GetAssessmentList();

    /// <summary>
    /// Gets a list of assessment lists
    /// </summary>
    /// <returns>A result containing a list of assessment lists or an error if the operation fails</returns>
    Task<Result<List<AssessmentsListDto>>> GetAssessmentsList();

    /// <summary>
    /// Invites a user to an assessment list
    /// </summary>
    /// <param name="req">The invitation request containing email and list ID</param>
    /// <returns>A result indicating whether the invitation was successful or an error if the operation fails</returns>
    Task<Result<bool>> InviteUserToAssessmentList(UserAssessmentListInvite req);

    /// <summary>
    /// Gets all users assigned to a specific assessment with their roles
    /// </summary>
    /// <param name="logID">The assessment log ID to get users for</param>
    /// <returns>A result containing an array of users with their role information or an error if the operation fails</returns>
    Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToAssessment(int logID);

    /// <summary>
    /// Gets all users assigned to a specific assessment list with their roles
    /// </summary>
    /// <param name="logID">The assessment list ID to get users for</param>
    /// <returns>A result containing an array of users with their role information or an error if the operation fails</returns>
    Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToList(int logID);

    /// <summary>
    /// Saves an assessment list by sending a POST request to the API
    /// </summary>
    /// <param name="req">The assessment list request data to save</param>
    /// <returns>A result containing the saved assessment list response or an error if the operation fails</returns>
    Task<Result<AssessmentListResponseDto>> SaveAssessmentList(AssessmentListRequestDto req);

    /// <summary>
    /// Removes a user from a list on the assessment
    /// </summary>
    /// <param name="userId">The user being removed</param>
    /// <param name="listId">The list Id</param>
    /// <returns></returns>
    Task<Result<bool>> RemoveUserFromAssessmentList(int userId, int listId);

    /// <summary>
    /// Remove a list 
    /// </summary>
    /// <param name="listId">Remove a list. Will remove all users from that list and delete</param>
    /// <returns>Bool if success</returns>
    Task<Result<bool>> RemoveList(int listId);

    /// <summary>
    /// Gets a list of lgaids and their counts
    /// </summary>
    /// <returns></returns>
    Task<Result<LGAidCounts[]>> GetLgAids();

    /// <summary>
    /// Gets facilities for a specific lgAid
    /// </summary>
    /// <param name="lgAid">The lgAid filter</param>
    /// <returns>A list of facilities and their lgaid</returns>
    Task<Result<FacilityCoords[]>> GetFacilitesForLgAId(string lgAid);
}
