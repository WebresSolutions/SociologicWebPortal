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
    [Parameter] public int FacilityId { get; set; }

    #region Private Fields

    /// <summary>
    /// The detailed facility data loaded from the API
    /// </summary>
    private FacilityDTO? _details = null!;

    /// <summary>
    /// Indicates whether the facility is currently being saved
    /// </summary>
    private bool _isSaving;

    /// <summary>
    /// 
    /// </summary>
    private ShowModeEnum _showmode = ShowModeEnum.Single;
    #endregion

    /// <summary>
    /// Load facility details
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        IsLoading = true;
        Result<FacilityDTO> result = await ApiService.GetFacility(FacilityId);
        if (result is { IsSuccess: true, Value: not null })
        {
            _details = result.Value;
            _details!.FacilityDetails.Coordinates ??= new(); // Ensure Coordinates is not null
        }
        else
        {
            _ = await DialogService.ShowMessageBox("Error", result.ErrorDescription ?? "Failed to load facility details");
        }
        _showmode = ShowModeEnum.Single;
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
        _isSaving = true;
        if (editContext.Validate())
        {
            Result<FacilityDTO> result = await ApiService.SaveFacility(_details!.FacilityDetails);
            if (result is { IsSuccess: true, Value: not null })
            {
                _details = result.Value;
                _details!.FacilityDetails.Coordinates ??= new(); // Ensure Coordinates is not null
            }

            _ = result.IsSuccess ? _snackbar.Add("Save successful", Severity.Success) : _snackbar.Add("Failed to save.", Severity.Error);
        }
        _isSaving = false;
    }

    /// <summary>
    /// Navigate to assessment view
    /// </summary>
    /// <param name="assessmentLogId"></param>
    private void ViewAssessment(int assessmentLogId) => NavigationManager.NavigateTo($"Assessments/{assessmentLogId}");

    private void CoordsUpdated(FacilityCoords coords)
    {
        if (_details?.FacilityDetails.Coordinates is not null)
        {
            _details.FacilityDetails.Coordinates.Latitude = coords.latitude;
            _details.FacilityDetails.Coordinates.Longitude = coords.longitude;
        }
    }
}