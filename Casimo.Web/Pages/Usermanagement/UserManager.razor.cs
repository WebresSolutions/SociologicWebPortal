using Casimo.Shared.ApiModels.User;
using Casimo.Shared.ResponseModels;

namespace Casimo.Web.Pages.Usermanagement
{
    /// <summary>
    /// Code-behind class for the UserManager page
    /// Handles user data loading, navigation, and dialog management for user administration
    /// </summary>
    public partial class UserManager
    {
        #region Private Fields 
        
        /// <summary>
        /// Collection of users retrieved from the API
        /// </summary>
        private List<UserDto>? _users = [];
        
        /// <summary>
        /// Controls the visibility of the create user dialog
        /// </summary>
        private bool _visible = false;
        
        #endregion

        /// <summary>
        /// Loads data into the page when the component is initialized
        /// Retrieves all users from the API and displays them in the data grid
        /// </summary>
        /// <returns>A task representing the asynchronous operation</returns>
        protected override async Task OnInitializedAsync()
        {
            IsLoading = true;
            Result<List<UserDto>>? result = await _apiService.GetAllUsers();
            if (result.IsSuccess && result.Value is not null)
            {
                _users = result.Value;
            }
            else
            {
                _snackbar.Add("Failed to load users", MudBlazor.Severity.Error);
            }
            base.IsLoading = false;
            StateHasChanged();
        }

        /// <summary>
        /// Navigates to the individual user management page for the specified user
        /// </summary>
        /// <param name="userId">The identifier of the user to edit</param>
        private void NavigateToUserPage(string userId)
        {
            _navigationManager.NavigateTo($"/UserManager/{userId}");
        }

        /// <summary>
        /// Shows the create user dialog by setting the visibility flag to true
        /// </summary>
        private void ViewCreateDialog()
        {
            _visible = true;
        }
    }
}