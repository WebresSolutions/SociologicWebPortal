using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ResponseModels;
using GoogleMapsComponents;
using GoogleMapsComponents.Maps;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using MouseEvent = GoogleMapsComponents.Maps.MouseEvent;

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
    /// Reference to the Google Maps component
    /// </summary>
    private GoogleMap? _map1;

    /// <summary>
    /// Configuration options for the Google Maps display
    /// </summary>
    private MapOptions? _mapOptions;

    /// <summary>
    /// The draggable marker representing the facility location on the map
    /// </summary>
    private Marker? _facilityMarker;

    /// <summary>
    /// Indicates whether the facility is currently being saved
    /// </summary>
    private bool _isSaving;

    #endregion

    /// <summary>
    /// Load facility details
    /// </summary>
    /// <returns></returns>
    protected override async Task OnParametersSetAsync()
    {
        IsLoading = true;
        Result<FacilityDTO> result = await ApiService.GetFacility(FacilityId);
        if (result is { IsSuccess: true, Value: not null })
        {
            _details = result.Value;
            _details!.FacilityDetails.Coordinates ??= new(); // Ensure Coordinates is not null
        }
        else
        {
            await DialogService.ShowMessageBox("Error", result.ErrorDescription ?? "Failed to load facility details");
        }

        double lat = _details?.FacilityDetails.Coordinates?.Latitude ?? 0;
        double lng = _details?.FacilityDetails.Coordinates?.Longitude ?? 0;

        _mapOptions = new()
        {
            Zoom = 13,
            Center = new LatLngLiteral(lat, lng),
            MapTypeId = MapTypeId.Roadmap,
            MapId = "FacilityMap"
        };

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

            if (result.IsSuccess)
                _snackbar.Add("Save successful", Severity.Success);
            else
                _snackbar.Add("Failed to save.", Severity.Error);
        }
        _isSaving = false;
    }

    /// <summary>
    /// Load map details once the map has been rendered
    /// </summary>
    /// <returns></returns>
    private async Task AfterMapRender()
    {
        try
        {
            if (_map1?.InteropObject == null || _details?.FacilityDetails.Coordinates == null)
                return;

            double lat = _details.FacilityDetails.Coordinates.Latitude ?? 0;
            double lng = _details.FacilityDetails.Coordinates.Longitude ?? 0;

            // Create draggable marker using GoogleMapsComponents
            _facilityMarker = await Marker.CreateAsync(_map1.JsRuntime, new MarkerOptions()
            {
                Position = new LatLngLiteral(lat, lng),
                Map = _map1.InteropObject,
                Draggable = true, // Enable dragging
                Title = $"Facility {FacilityId}",
                Label = new MarkerLabel
                {
                    Text = "F",
                    FontWeight = "bold",
                    Color = "#FFFFFF",
                    FontSize = "16px"
                }
            });

            // Add drag event listeners
            await _facilityMarker.AddListener<MouseEvent>("dragstart", async e =>
            {
                Console.WriteLine($"Started dragging facility marker {FacilityId}");
                await OnMarkerDragStart();
            });

            await _facilityMarker.AddListener<MouseEvent>("drag", async e =>
            {
                // Optional: Handle continuous drag events
                LatLngLiteral currentPosition = await _facilityMarker.GetPosition();
                Console.WriteLine($"Dragging to: {currentPosition.Lat}, {currentPosition.Lng}");
            });

            await _facilityMarker.AddListener<MouseEvent>("dragend", async e =>
            {
                LatLngLiteral newPosition = await _facilityMarker.GetPosition();
                Console.WriteLine($"Facility marker {FacilityId} dragged to: {newPosition.Lat}, {newPosition.Lng}");

                OnMarkerDragEnd(newPosition.Lat, newPosition.Lng);
            });

            // Optional: Add click listener
            await _facilityMarker.AddListener<MouseEvent>("click", e =>
            {
                Console.WriteLine($"Clicked on facility marker {FacilityId}");
                OnMarkerClick();
            });

            Console.WriteLine("Native GoogleMaps marker with drag functionality created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting up marker: {ex.Message}");
        }
    }

    /// <summary>
    /// Called when the marker is first dragged
    /// </summary>
    /// <returns></returns>
    private Task OnMarkerDragStart()
    {
        // Handle when drag starts
        Console.WriteLine("Marker drag started");
        return Task.CompletedTask;
    }

    /// <summary>
    /// When the marker has finished dragging. This will update the facility data
    /// </summary>
    /// <param name="lat"></param>
    /// <param name="lng"></param>
    /// <returns></returns>
    private void OnMarkerDragEnd(double lat, double lng)
    {
        try
        {
            Console.WriteLine($"Facility {FacilityId} moved to new position: {lat}, {lng}");

            // Update the details object if needed
            if (_details?.FacilityDetails.Coordinates != null)
            {
                _details.FacilityDetails.Coordinates.Latitude = lat;
                _details.FacilityDetails.Coordinates.Longitude = lng;
            }

            // Trigger UI update
            StateHasChanged();

            // Perform any additional logic
            OnMarkerMoved(lat, lng);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in OnMarkerDragEnd: {ex.Message}");
        }
    }

    /// <summary>
    /// When the marker is clicked shows a popup
    /// </summary>
    private void OnMarkerClick()
    {
        // Handle marker click events
        Console.WriteLine($"Marker for facility {FacilityId} was clicked");
        // You could show facility details, open a popup, etc.
    }

    /// <summary>
    /// Called when the marker has moved
    /// </summary>
    /// <param name="lat"></param>
    /// <param name="lng"></param>
    private void OnMarkerMoved(double lat, double lng)
    {
        try
        {

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating facility location: {ex.Message}");

        }
    }

    /// <summary>
    /// Navigate to assessment view
    /// </summary>
    /// <param name="assessmentLogId"></param>
    private void ViewAssessment(int assessmentLogId)
    {
        NavigationManager.NavigateTo($"Assessments/{assessmentLogId}");
    }
}