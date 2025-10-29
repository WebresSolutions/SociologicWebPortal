using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Casimo.Shared.WebModels;
using MudBlazor;

namespace Casimo.Web.Pages.Facility;

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
    private PagedResponse<FacilityListItemDto>? _pagedResponse;

    /// <summary>
    /// Number of rows to display per page in the data grid
    /// </summary>
    private readonly int _rowsPerPage = 25;

    /// <summary>
    /// Reference to the data grid for manual refresh operations
    /// </summary>
    private MudDataGrid<FacilityListItemDto>? _grid;

    /// <summary>
    /// Session data for the facilities page
    /// </summary>
    private FacilitiesSessionData _sessionData = new();

    #endregion

    #region Constants
    private const string _FacilitiesSessionKey = "FacilitiesSession";
    #endregion

    /// <summary>
    /// Called when the component is initialized.
    /// Data loading for the grid is now handled by LoadFacilitiesServerData.
    /// </summary>
    /// <returns>A task representing the asynchronous operation</returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        // Restore session data
        FacilitiesSessionData? savedSession = _sessionStorage.GetItem<FacilitiesSessionData>(_FacilitiesSessionKey);
        if (savedSession is not null)
            _sessionData = savedSession;
    }

    /// <summary>
    /// Saves the current session data to session storage
    /// </summary>
    private void SaveSessionData() => _sessionStorage.SetItem(_FacilitiesSessionKey, _sessionData);

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

            // Handle sorting from grid state
            SortDefinition<FacilityListItemDto>? sortDefinition = state.SortDefinitions.FirstOrDefault();
            if (sortDefinition != null)
            {
                // Set order direction
                _sessionData.Order = sortDefinition.Descending ? SortDirectionEnum.Desc : SortDirectionEnum.Asc;

                // Map the property name to the API's expected orderby value
                _sessionData.OrderBy = sortDefinition.SortBy switch
                {
                    nameof(FacilityListItemDto.SiteName) or
                    nameof(FacilityListItemDto.Address) or
                    nameof(FacilityListItemDto.Operator) or
                    nameof(FacilityListItemDto.Owner) or
                    nameof(FacilityListItemDto.PostCode) or
                    nameof(FacilityListItemDto.Settlement) or
                    nameof(FacilityListItemDto.LgAid) => sortDefinition.SortBy,
                    _ => nameof(FacilityListItemDto.SiteName) // Default
                };
            }
            else
            {
                // Default sorting if no sort definition
                _sessionData.OrderBy = nameof(FacilityListItemDto.SiteName);
                _sessionData.Order = SortDirectionEnum.Asc;
            }

            // Save current state to session
            _sessionData.Page = state.Page;
            _sessionData.PageSize = state.PageSize;
            _sessionData.PageSize = state.PageSize;
            SaveSessionData();

            Result<PagedResponse<FacilityListItemDto>>? apiResult = await _apiService.GetAllFacilities(
                apiPageSize,
                apiPageNumber,
                _sessionData.SearchString,
                _sessionData.OrderBy,
                _sessionData.Order);

            if (apiResult is not null && apiResult.IsSuccess && apiResult.Value is not null)
            {
                _pagedResponse = apiResult.Value;
                // MudDataGrid requires GridData with Items for the current page and TotalItems count
                return new GridData<FacilityListItemDto>()
                {
                    Items = _pagedResponse.Result ?? Enumerable.Empty<FacilityListItemDto>(),
                    TotalItems = _pagedResponse.TotalCount
                };
            }
            else
            {
                // Handle API error or unsuccessful result
                string errorMessage = "Failed to load facilities data from the API.";
                Console.WriteLine($"API Error: {errorMessage}");
                if (_dialogService is not null)
                {
                    _ = await _dialogService.ShowMessageBox("Error", errorMessage);
                }
                return new GridData<FacilityListItemDto>() { Items = [], TotalItems = 0 };
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
            if (_dialogService != null)
            {
                _ = await _dialogService.ShowMessageBox("Error", "An unexpected error occurred while fetching facilities.");
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
    /// Handles search input changes and triggers grid data reload with the new search criteria
    /// </summary>
    /// <param name="text">The search text entered by the user</param>
    /// <returns>A task representing the asynchronous operation</returns>
    private Task OnSearch(string text)
    {
        _sessionData.SearchString = text;
        // Reset to first page when search changes
        _sessionData.Page = 0;
        SaveSessionData();
        return _grid!.ReloadServerData();
    }

    private Task ClearSearch()
    {
        _sessionData.SearchString = string.Empty;
        _sessionData.Page = 0;
        _sessionStorage.RemoveItem(_FacilitiesSessionKey);
        _sessionData = new FacilitiesSessionData(); // Reset to defaults
        return _grid!.ReloadServerData();
    }
}