using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ResponseModels;
using MudBlazor;

namespace Casimo.Web.Pages.Facility
{
    /// <summary>
    /// Code-behind class for the Facilities page
    /// Handles data loading, pagination, and search functionality for facility management
    /// </summary>
    public partial class Facilities // This inherits BaseDataComponent as per your .razor
    {
        #region Private Fields

        /// <summary>
        /// Stores the last paged response for facilities data
        /// </summary>
        private PagedResponse<FacilityListItemDto>? _pagedResponse; // Can be useful to store the last paged response

        /// <summary>
        /// Number of rows to display per page in the data grid
        /// </summary>
        private readonly int _rowsPerPage = 25;

        /// <summary>
        /// Reference to the data grid for manual refresh operations
        /// </summary>
        private MudDataGrid<FacilityListItemDto>? _grid; // Reference to the grid for manual refresh

        /// <summary>
        /// Search string for filtering facilities by name
        /// </summary>
        private string? searchString = null;

        #endregion

        /// <summary>
        /// Called when the component is initialized.
        /// Data loading for the grid is now handled by LoadFacilitiesServerData.
        /// </summary>
        /// <returns>A task representing the asynchronous operation</returns>
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            // The MudDataGrid will automatically call LoadFacilitiesServerData for the initial data load.
        }

        /// <summary>
        /// This method is called by the MudDataGrid to fetch data when needed (paging, sorting, filtering).
        /// Implements server-side data loading with pagination and search capabilities.
        /// </summary>
        /// <param name="state">The current grid state containing pagination and sorting information</param>
        /// <returns>A GridData object containing the current page of facilities and total count</returns>
        private async Task<GridData<FacilityListItemDto>> LoadFacilitiesServerData(GridState<FacilityListItemDto> state)
        {
            IsLoading = true;

            try
            {
                int apiPageNumber = state.Page;
                int apiPageSize = state.PageSize;
                apiPageNumber++;


                Result<PagedResponse<FacilityListItemDto>>? apiResult = await _apiService.GetAllFacilities(apiPageSize, apiPageNumber, searchString);

                if (apiResult is not null && apiResult.IsSuccess && apiResult.Value is not null)
                {
                    _pagedResponse = apiResult.Value;
                    // MudDataGrid requires GridData with Items for the current page and TotalItems count
                    return new GridData<FacilityListItemDto>()
                    {
                        Items = _pagedResponse.Result ?? Enumerable.Empty<FacilityListItemDto>(),
                        TotalItems = _pagedResponse.TotalCount // Ensure PagedResponse<T> has TotalCount
                    };
                }
                else
                {
                    // Handle API error or unsuccessful result
                    string errorMessage = "Failed to load facilities data from the API.";
                    Console.WriteLine($"API Error: {errorMessage}"); // Log to console or proper logger
                    if (_dialogService is not null) // Check if DialogService is available
                    {
                        await _dialogService.ShowMessageBox("Error", errorMessage);
                    }
                    return new GridData<FacilityListItemDto>() { Items = [], TotalItems = 0 };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}"); // Log to console or proper logger
                if (_dialogService != null)
                {
                    await _dialogService.ShowMessageBox("Error", "An unexpected error occurred while fetching facilities.");
                }
                return new GridData<FacilityListItemDto>() { Items = Enumerable.Empty<FacilityListItemDto>(), TotalItems = 0 };
            }
            finally
            {
                IsLoading = false;
            }
        }

        /// <summary>
        /// Manually refreshes the grid's data from another action (e.g., after adding/editing a facility)
        /// </summary>
        /// <returns>A task representing the asynchronous operation</returns>
        public async Task RefreshGridData()
        {
            if (_grid is not null)
                await _grid.ReloadServerData();
        }

        /// <summary>
        /// Navigates to the facility details page for the specified facility ID
        /// </summary>
        /// <param name="facilityId">The identifier of the facility to view</param>
        public void ViewFacilty(int facilityId)
        {
            _navigationManager.NavigateTo($"/Facilities/{facilityId}");
        }

        /// <summary>
        /// Handles search input changes and triggers grid data reload with the new search criteria
        /// </summary>
        /// <param name="text">The search text entered by the user</param>
        /// <returns>A task representing the asynchronous operation, or null if no grid reference exists</returns>
        private Task OnSearch(string text)
        {
            searchString = text;
            return _grid!.ReloadServerData();
        }
    }
}