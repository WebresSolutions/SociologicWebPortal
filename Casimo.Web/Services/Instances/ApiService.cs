using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.ApiModels.User;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Casimo.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace Casimo.Web.Services.Instances;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;
    private readonly HttpClient _anonymousHttpClient;
    private readonly NavigationManager _navigationManager;

    public ApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration, NavigationManager navigationManager)
    {
        string httpClientName = configuration.GetValue<string>("HttpClient")
            ?? throw new Exception("Failed to load the http client settings");

        _httpClient = httpClientFactory.CreateClient(httpClientName);
        _anonymousHttpClient = httpClientFactory.CreateClient("Anonymous");
        _navigationManager = navigationManager;
    }
    /// <summary>
    /// Gets all application users
    /// </summary>
    /// <returns>List of dtos</returns>
    public async Task<Result<List<UserDto>>> GetAllUsers()
    {
        Result<List<UserDto>> result = new();
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/UserManager/Users");
            if (response.IsSuccessStatusCode)
            {
                result.Value = await response.Content.ReadFromJsonAsync<List<UserDto>>();
            }
            else
            {
                if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                    await NavigationToLoginPage();

                result.ConvertHttpResponseToError(response.StatusCode);
                result.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            result.Error = ErrorType.InternalError;
        }
        return result;
    }

    /// <summary>
    /// Get details for a specific user
    /// </summary>
    /// <param name="userId">The User Id </param>
    /// <returns>A result of user details</returns>
    public async Task<Result<ManageUserDetailsDto>> GetUserDetails(string userId)
    {
        Result<ManageUserDetailsDto> result = new();
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/UserManager/User/{userId}");
            if (response.IsSuccessStatusCode)
            {
                result.Value = await response.Content.ReadFromJsonAsync<ManageUserDetailsDto>();
            }
            else
            {
                if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                    await NavigationToLoginPage();

                result.ConvertHttpResponseToError(response.StatusCode);
                result.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            result.Error = ErrorType.InternalError;
        }
        return result;
    }

    /// <summary>
    /// Saves a user details and roles
    /// </summary>
    /// <param name="userId">The User Id</param>
    /// <param name="req">The Request to save</param>
    /// <returns>A result containing the updated user details or an error if the operation fails</returns>
    public async Task<Result<ManageUserDetailsDto>> SaveUserDetails(string userId, ManageUserDetailsDto req)
    {
        Result<ManageUserDetailsDto> res = new();
        try
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"api/UserManager/User/{userId}", req);

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                res.Value = await response.Content.ReadFromJsonAsync<ManageUserDetailsDto>();
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
        return res;
    }

    /// <summary>
    /// Get the user roles
    /// </summary>
    /// <returns>A collection of user roles</returns>
    public async Task<Result<List<UserRolesDto>>> GetUserRoles()
    {
        Result<List<UserRolesDto>> res = new();
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/UserManager/Roles");

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                List<UserRolesDto> roles = await response.Content.ReadFromJsonAsync<List<UserRolesDto>>() ?? [];
                res.Value = roles;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Gets all facilities with pagination and optional name filtering
    /// </summary>
    /// <param name="pageSize">The number of facilities to return per page</param>
    /// <param name="pageNumber">The page number to retrieve</param>
    /// <param name="nameFilter">Optional filter to search facilities by name</param>
    /// <returns>A result containing a paged response of facilities or an error if the operation fails</returns>
    public async Task<Result<PagedResponse<FacilityListItemDto>>> GetAllFacilities(int pageSize, int pageNumber, string? nameFilter, string? orderby, SortDirectionEnum order)
    {
        Result<PagedResponse<FacilityListItemDto>> res = new();
        try
        {
            Dictionary<string, string> queryParameters = new()
            {
                { "pageSize", pageSize.ToString() },
                { "page", pageNumber.ToString() },
                { "order", ((int)order).ToString() }
            };

            if (nameFilter is not null)
                queryParameters.Add("nameFilter", nameFilter ?? string.Empty);


            if (orderby is not null)
                queryParameters.Add("orderby", orderby ?? string.Empty);

            FormUrlEncodedContent dictFormUrlEncoded = new(queryParameters);
            string queryString = await dictFormUrlEncoded.ReadAsStringAsync();

            HttpResponseMessage response = await _httpClient.GetAsync($"api/Facilities/All?{queryString}");

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                PagedResponse<FacilityListItemDto>? facilities = await response.Content.ReadFromJsonAsync<PagedResponse<FacilityListItemDto>>();
                res.Value = facilities;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Get a specific facility by its ID along with its subspaces and assessment logs.
    /// </summary>
    /// <param name="facilityId"></param>
    /// <returns></returns>
    public async Task<Result<FacilityDTO>> GetFacility(int facilityId)
    {
        Result<FacilityDTO> res = new();
        try
        {
            HttpResponseMessage response = await _anonymousHttpClient.GetAsync($"api/Facilities/{facilityId}");

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                FacilityDTO? facilities = await response.Content.ReadFromJsonAsync<FacilityDTO>();
                res.Value = facilities;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the facility";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Save the details of the facilty
    /// </summary>
    /// <param name="req">Contains facility details</param>
    /// <returns>The facility</returns>
    public async Task<Result<FacilityDTO>> SaveFacility(FacilityDetailsDto req)
    {
        Result<FacilityDTO> res = new();
        try
        {
            HttpResponseMessage response = await _anonymousHttpClient.PostAsJsonAsync($"api/Facilities", req);

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                FacilityDTO? facilities = await response.Content.ReadFromJsonAsync<FacilityDTO>();
                res.Value = facilities;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to save the facility";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Gets a specific assessment by its ID
    /// </summary>
    /// <param name="assessmentId">The assessment ID to retrieve</param>
    /// <returns>A result containing the assessment details or an error if not found</returns>
    public async Task<Result<AssessmentLogDetailDto>> GetAssessment(int assessmentId)
    {

        Result<AssessmentLogDetailDto> res = new();
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/SuitabilityAssessment/{assessmentId}");

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                AssessmentLogDetailDto? ffpAssessment = await response.Content.ReadFromJsonAsync<AssessmentLogDetailDto>();
                res.Value = ffpAssessment;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Saves the assessment list
    /// </summary>
    /// <param name="req">The request containing the assessment data to save</param>
    /// <returns>A result containing the saved question response details or an error if the operation fails</returns>
    public async Task<Result<AssessmentLogDetailDto>> SaveQuestions(SaveQuestionResListDto req)
    {
        Result<AssessmentLogDetailDto> res = new();
        try
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"api/SuitabilityAssessment/SaveQuestionResponse", req);

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                AssessmentLogDetailDto? ffpAssessment = await response.Content.ReadFromJsonAsync<AssessmentLogDetailDto>();
                res.Value = ffpAssessment;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Gets user assignments for a specific user or the current user
    /// </summary>
    /// <param name="userId">The user ID to get assignments for (0 for current user)</param>
    /// <returns>A result containing the user's assessment assignments or an error if the operation fails</returns>
    public async Task<Result<List<UserAssessmentListDto>>> GetUserAssignments(int userId = 0)
    {
        Result<List<UserAssessmentListDto>> res = new();
        try
        {
            List<UserAssessmentListDto>? response = await _httpClient.GetFromJsonAsync<List<UserAssessmentListDto>>($"api/SuitabilityAssessment/UserAssessments/{userId}");

            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assigned assessments list";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Gets a list of assessments
    /// </summary>
    /// <returns>A result containing a list of assessments or an error if the operation fails</returns>
    public async Task<Result<List<AssessmentListItemDto>>> GetAssessmentList()
    {
        Result<List<AssessmentListItemDto>> res = new();
        try
        {
            List<AssessmentListItemDto>? response = await _httpClient.GetFromJsonAsync<List<AssessmentListItemDto>>($"api/SuitabilityAssessment/All");
            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assessment list";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
            // Handle exception
        }

        return res;
    }

    /// <summary>
    /// Gets a list of assessment lists
    /// </summary>
    /// <returns>A result containing a list of assessment lists or an error if the operation fails</returns>
    public async Task<Result<List<AssessmentsListDto>>> GetAssessmentsList()
    {
        Result<List<AssessmentsListDto>> res = new();
        try
        {
            List<AssessmentsListDto>? response = await _httpClient.GetFromJsonAsync<List<AssessmentsListDto>>($"api/SuitabilityAssessment/AssessmentList");
            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assessment list";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        return res;
    }

    /// <summary>
    /// Invites a user to an assessment list
    /// </summary>
    /// <param name="req">The invitation request containing email and list ID</param>
    /// <returns>A result indicating whether the invitation was successful or an error if the operation fails</returns>
    public async Task<Result<bool>> InviteUserToAssessmentList(UserAssessmentListInvite req)
    {
        Result<bool> res = new();
        try
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync($"api/UserManager/InviteUserToAssessmentList", req);

            if (response.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (response.IsSuccessStatusCode)
            {
                bool? isSuccess = await response.Content.ReadFromJsonAsync<bool>();
                res.Value = isSuccess ?? false;
            }
            else
            {
                res.ConvertHttpResponseToError(response.StatusCode);
                res.ErrorDescription = await response.Content.ReadAsStringAsync() ?? "Failed to get the user details";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Gets all users assigned to a specific assessment with their roles
    /// </summary>
    /// <param name="logID">The assessment log ID to get users for</param>
    /// <returns>A result containing an array of users with their role information or an error if the operation fails</returns>
    public async Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToAssessment(int logID)
    {
        Result<UsersAssignedToAssessmentDto[]> res = new();
        try
        {
            UsersAssignedToAssessmentDto[]? response = await _httpClient.GetFromJsonAsync<UsersAssignedToAssessmentDto[]>($"api/SuitabilityAssessment/UsersAssignedToLog/{logID}");
            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assessment list";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Gets all users assigned to a specific assessment list with their roles
    /// </summary>
    /// <param name="logID">The assessment list ID to get users for</param>
    /// <returns>A result containing an array of users with their role information or an error if the operation fails</returns>
    public async Task<Result<UsersAssignedToAssessmentDto[]>> GetUsersAssignedToList(int logID)
    {
        Result<UsersAssignedToAssessmentDto[]> res = new();
        try
        {
            UsersAssignedToAssessmentDto[]? response = await _httpClient.GetFromJsonAsync<UsersAssignedToAssessmentDto[]>($"api/SuitabilityAssessment/UsersAssignedToList/{logID}");
            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assessment list";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Saves an assessment list by sending a POST request to the API
    /// </summary>
    /// <param name="req">The assessment list request data to save</param>
    /// <returns>A result containing the saved assessment list response or an error if the operation fails</returns>
    public async Task<Result<AssessmentListResponseDto>> SaveAssessmentList(AssessmentListRequestDto req)
    {
        Result<AssessmentListResponseDto> res = new();
        try
        {
            HttpResponseMessage saveResult = await _httpClient.PostAsJsonAsync($"api/SuitabilityAssessment/AssessmentList", req);

            if (saveResult.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (saveResult is not null)
            {
                res.Value = await saveResult.Content.ReadFromJsonAsync<AssessmentListResponseDto>();
            }
            else
            {
                res.ErrorDescription = "Failed to get the users assessment list";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Removes a user from a list on the assessment
    /// </summary>
    /// <param name="userId">The user being removed</param>
    /// <param name="listId">The list Id</param>
    /// <returns></returns>
    public async Task<Result<bool>> RemoveUserFromAssessmentList(int userId, int listId)
    {
        Result<bool> res = new();
        try
        {
            HttpResponseMessage? deleteResult = await _httpClient.DeleteAsync($"api/UserManager/RemoveUserFromList/{userId}/{listId}");

            if (deleteResult.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (deleteResult is not null)
            {
                res.Value = await deleteResult.Content.ReadFromJsonAsync<bool>();
            }
            else
            {
                res.ErrorDescription = "Failed to delete the user";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Removes an assessment list by its identifier
    /// </summary>
    /// <param name="listId">The assessment list identifier to remove</param>
    /// <returns>A result indicating whether the removal was successful or an error if the operation fails</returns>
    public async Task<Result<bool>> RemoveList(int listId)
    {
        Result<bool> res = new();
        try
        {
            HttpResponseMessage? deleteResult = await _httpClient.DeleteAsync($"api/SuitabilityAssessment/AssessmentList/{listId}");

            if (deleteResult.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();

            if (deleteResult is not null)
            {
                res.Value = await deleteResult.Content.ReadFromJsonAsync<bool>();
            }
            else
            {
                res.ErrorDescription = "Failed to delete the list";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    /// <summary>
    /// Gets a list of LGAids and their counts
    /// </summary>
    /// <returns></returns>
    public async Task<Result<LGAidCounts[]>> GetLgAids()
    {
        Result<LGAidCounts[]> res = new();
        try
        {
            LGAidCounts[]? response = await _anonymousHttpClient.GetFromJsonAsync<LGAidCounts[]>($"api/Facilities/LGAids");
            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the LGAid counts";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    public async Task<Result<FacilityCoords[]>> GetFacilitesForLgAId(string lgAid)
    {
        Dictionary<string, string> queryParameters = new()
            {
                { "lgAid", lgAid},
            };

        string querystring = await new FormUrlEncodedContent(queryParameters).ReadAsStringAsync();

        Result<FacilityCoords[]> res = new();
        try
        {
            FacilityCoords[]? response = await _anonymousHttpClient.GetFromJsonAsync<FacilityCoords[]>($"api/Facilities/LGAid?{querystring}");

            if (response is not null)
            {
                res.Value = response;
            }
            else
            {
                res.ErrorDescription = "Failed to get the LGAid counts";
            }
        }
        catch (HttpRequestException httpEx)
        {
            if (httpEx.StatusCode is System.Net.HttpStatusCode.Unauthorized)
                await NavigationToLoginPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        return res;
    }

    private async Task NavigationToLoginPage()
    {
        string returnUrl = _navigationManager.ToBaseRelativePath(_navigationManager.Uri);
        string loginUrl = $"{_navigationManager.BaseUri}Identity/Account/Login?returnUrl={returnUrl}";
        _navigationManager.NavigateTo(loginUrl, true);
    }
}

