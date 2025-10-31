using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace Casimo.Web.Pages.Facility;

public partial class FacilityDetails
{
    /// <summary>
    /// Gets or sets the facility identifier from the route parameter
    /// </summary>
    [Parameter]
    public int FacilityId { get; set; }

    #region Private Fields

    /// <summary>
    /// The detailed facility data loaded from the API
    /// </summary>
    private FacilityDTO? details = null!;

    /// <summary>
    /// Indicates whether the facility is currently being saved
    /// </summary>
    private bool isSaving;

    /// <summary>
    /// 
    /// </summary>
    private MapMode MapMode = MapMode.Single;
    #endregion

    /// <summary>
    /// Previous FacilityId to detect changes
    /// </summary>
    private int previousFacilityId;

    /// <summary>
    /// Load facility details on initial load
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        previousFacilityId = FacilityId;
        await LoadFacilityDetails();
    }

    /// <summary>
    /// Called when parameters change - reloads facility data if FacilityId changed
    /// </summary>
    /// <returns></returns>
    protected override async Task OnParametersSetAsync()
    {
        if (previousFacilityId != FacilityId)
        {
            previousFacilityId = FacilityId;
            await LoadFacilityDetails();
        }
    }

    /// <summary>
    /// Loads facility details from the API
    /// </summary>
    /// <returns></returns>
    private async Task LoadFacilityDetails()
    {
        IsLoading = true;
        Result<FacilityDTO> result = await _apiService.GetFacility(FacilityId);
        if (result is { IsSuccess: true, Value: not null })
        {
            details = result.Value;
            details!.FacilityDetails.Coordinates ??= new(); // Ensure Coordinates is not null
        }
        else
        {
            _ = await _dialogService.ShowMessageBox("Error", result.ErrorDescription ?? "Failed to load facility details");
        }
        MapMode = MapMode.Single;
        IsLoading = false;
        StateHasChanged();
    }

    /// <summary>
    /// Save
    /// </summary>
    /// <param name="editContext"></param>
    /// <returns></returns>
    private async Task SaveFacility(EditContext editContext)
    {
        isSaving = true;
        if (editContext.Validate())
        {
            Result<FacilityDTO> result = await _apiService.SaveFacility(details!.FacilityDetails);
            if (result is { IsSuccess: true, Value: not null })
            {
                details = result.Value;
                details!.FacilityDetails.Coordinates ??= new(); // Ensure Coordinates is not null
            }

            _ = result.IsSuccess ? _snackbar.Add("Save successful", Severity.Success) : _snackbar.Add("Failed to save.", Severity.Error);
        }
        isSaving = false;
    }

    /// <summary>
    /// Navigate to assessment view
    /// </summary>
    /// <param name="assessmentLogId"></param>
    private void ViewAssessment(int assessmentLogId) => _navigationManager.NavigateTo($"Assessments/{assessmentLogId}");

    /// <summary>
    /// Used by the event callback when coordinates are updated from the map component
    /// </summary>
    /// <param name="coords"></param>
    private void CoordsUpdated(FacilityCoords coords)
    {
        if (details?.FacilityDetails.Coordinates is not null)
        {
            details.FacilityDetails.Coordinates.Latitude = coords.latitude;
            details.FacilityDetails.Coordinates.Longitude = coords.longitude;
        }
    }

    /// <summary>
    /// Handles marker click navigation to facility details page
    /// </summary>
    /// <param name="facilityId">The facility ID to navigate to</param>
    private Task NavigateToFacility(int facilityId)
    {
        _navigationManager.NavigateTo($"/Facilities/{facilityId}");
        return Task.CompletedTask;
    }
}