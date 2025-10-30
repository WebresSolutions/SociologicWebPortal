using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Casimo.Web.Helpers;
using GoogleMapsComponents;
using GoogleMapsComponents.Maps;
using GoogleMapsComponents.Maps.Coordinates;
using Microsoft.AspNetCore.Components;

namespace Casimo.Web.Components.Facilities;

public partial class MapView : IDisposable
{
    /// <summary>
    /// Optional LGA filter to pre-select on load
    /// </summary>
    [Parameter]
    public string? LGAFilter { get; set; }

    /// <summary>
    /// Optional default coordinates to center the map on load
    /// </summary>
    [Parameter]
    public FacilityDetailsDto? DefaultDetails { get; set; }

    /// <summary>
    /// The show mode for the map. All or Single
    /// </summary>
    [Parameter]
    public required ShowModeEnum ShowMode { get; set; }

    /// <summary>
    /// If using a single facility, callback when coordinates are updated
    /// </summary>
    [Parameter]
    public EventCallback<FacilityCoords> OnUpdateCoords { get; set; }

    #region Private Fields
    /// <summary>
    /// Previous ShowMode to detect changes
    /// </summary>
    private ShowModeEnum? previousShowMode;

    /// <summary>
    /// A list of lgaid in the database with counts
    /// </summary>
    private LGAidCounts[] lgaids = [];

    /// <summary>
    /// A list of facilities for the selected LGAid
    /// </summary>
    private FacilityCoords[] facilities = [];

    /// <summary>
    /// The selected LGAid
    /// </summary>
    private string? selectedLGAid;

    /// <summary>
    /// Tracks if markers have been loaded to prevent unnecessary reloads
    /// </summary>
    private bool markersLoaded = false;

    /// <summary>
    /// Previous LGA filter to detect changes
    /// </summary>
    private string? previousLGAFilter;

    /// <summary>
    /// Reference to the Google Maps component
    /// </summary>
    private GoogleMap? map;

    /// <summary>
    /// Configuration options for the Google Maps display
    /// </summary>
    private MapOptions? mapOptions;

    /// <summary>
    /// The bounds of the map
    /// </summary>
    private LatLngBounds bounds = null!;

    /// <summary>
    /// the list of active markers on the map
    /// </summary>
    private Dictionary<FacilityCoords, AdvancedMarkerElement> markers = [];

    /// <summary>
    /// Marker clustering instance
    /// </summary>
    private MarkerClustering? markerClustering;
    #endregion

    /// <summary>
    /// Initial load of the component
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        mapOptions = new()
        {
            Zoom = 13,
            Center = new LatLngLiteral(-37.8162, 144.9640),
            MapTypeId = MapTypeId.Roadmap,
            MapId = Guid.NewGuid().ToString()
        };
        // Only reload LGAids if not already loaded
        if (lgaids.Length == 0)
        {
            Result<LGAidCounts[]> result = await _apiService.GetLgAids();
            lgaids = result.Value ?? [];
        }

        // Only reload markers if LGAFilter actually changed
        if (LGAFilter != previousLGAFilter && !string.IsNullOrEmpty(LGAFilter) && lgaids.Any(l => l.LGAidName == LGAFilter))
        {
            previousLGAFilter = LGAFilter;
            selectedLGAid = LGAFilter;
            markersLoaded = false;
            await ValueChanged(selectedLGAid);
        }

        // Initialize previousShowMode
        previousShowMode = ShowMode;

        StateHasChanged();
    }

    /// <summary>
    /// Called when parameters change - detect ShowMode changes
    /// </summary>
    protected override async Task OnParametersSetAsync()
    {
        if (DefaultDetails is not null && DefaultDetails.Coordinates is not null)
        {
            mapOptions!.Center = new LatLngLiteral(DefaultDetails.Coordinates.Latitude ?? 0, DefaultDetails.Coordinates.Longitude ?? 0);
        }
        // Check if ShowMode changed and we need to reload markers
        if (previousShowMode.HasValue && previousShowMode.Value != ShowMode && markersLoaded && !string.IsNullOrEmpty(selectedLGAid))
        {
            // Reload markers with the new mode without changing zoom
            await ReloadMarkersAsync(preserveZoom: true);
        }
        previousShowMode = ShowMode;
    }

    /// <summary>
    /// Public method to reload markers - can be called externally
    /// </summary>
    /// <param name="preserveZoom">If true, preserves the current zoom level when reloading</param>
    public async Task ReloadMarkersAsync(bool preserveZoom = false)
    {
        if (!string.IsNullOrEmpty(selectedLGAid))
            await ValueChanged(selectedLGAid, preserveZoom);
    }

    /// <summary>
    /// Called when the selected LGAid changes
    /// </summary>
    /// <param name="lgAid">The lgaid</param>
    /// <param name="preserveZoom">If true, preserves the current zoom level when reloading</param>
    /// <returns></returns>
    private async Task ValueChanged(string lgAid, bool preserveZoom = false)
    {
        selectedLGAid = lgAid;
        // Load the facilities now for the selected LGAid
        Result<FacilityCoords[]> facilitiesResult = await _apiService.GetFacilitesForLgAId(selectedLGAid);
        if (facilitiesResult.IsSuccess && facilitiesResult.Value is not null)
            facilities = facilitiesResult.Value;

        await ClearMarkers();

        if (ShowMode is ShowModeEnum.Single && DefaultDetails is not null)
            facilities = [.. facilities.Where(x => x.Id == DefaultDetails.FacilityId)];

        await LoadMapMarkersClustered(preserveZoom);
    }

    /// <summary>
    /// After the map has rendered, add markers for the facilities
    /// </summary>
    /// <param name="preserveZoom">If true, preserves the current zoom level by not calling FitBounds</param>
    /// <returns></returns>
    private async Task LoadMapMarkersClustered(bool preserveZoom = false)
    {
        try
        {
            if (map?.InteropObject is null || facilities.Length is 0)
                return;

            bounds = await LatLngBounds.CreateAsync(map.JsRuntime);

            // Create all marker tasks in parallel using LINQ
            List<(Task<AdvancedMarkerElement> MarkerTask, FacilityCoords Facility, LatLngLiteral Position)> markerData = [.. facilities.Select(facility =>
            {
                double lat = facility.latitude;
                LatLngLiteral latLng = new(lat, facility.longitude);
                bool isDefaultFacility = facility.Id == DefaultDetails?.FacilityId;
                string content = WebHelpers.FormatCoordinate(facility.Name, isDefaultFacility);

                Task<AdvancedMarkerElement> markerTask = AdvancedMarkerElement.CreateAsync(map.JsRuntime, new AdvancedMarkerElementOptions()
                {
                    Position = latLng,
                    Title = facility.Name,
                    Content = content,
                    GmpClickable = true,
                    GmpDraggable = isDefaultFacility
                });

                return (MarkerTask: markerTask, Facility: facility, Position: latLng);
            })];

            // Await all markers to be created
            AdvancedMarkerElement[] completedMarkers = await Task.WhenAll(markerData.Select(m => m.MarkerTask));

            // Extend bounds with all positions in parallel
            await Task.WhenAll(markerData.Select(m => bounds.Extend(m.Position)));

            // Build markers dictionary
            markers = completedMarkers
                .Zip(markerData, (marker, data) => (marker, data.Facility))
                .ToDictionary(x => x.Facility, x => x.marker);

            // Create marker clustering
            markerClustering = await MarkerClustering.CreateAsync(
                map.JsRuntime,
                map.InteropObject,
                markers.Values
            );

            // Add all event listeners in parallel
            List<Task> listenerTasks = new(markers.Count * 2);

            foreach (KeyValuePair<FacilityCoords, AdvancedMarkerElement> kvp in markers)
            {
                listenerTasks.Add(kvp.Value.AddListener("click", () => OnMarkerClick(kvp.Key.Id)));

                // Only add dragend listener for the default facility
                if (kvp.Key.Id == DefaultDetails?.FacilityId)
                    listenerTasks.Add(kvp.Value.AddListener<MouseEvent>("dragend", async (e) =>
                    {
                        await HandleDragEnd(e, kvp);
                    }));
            }

            await Task.WhenAll(listenerTasks);

            // Only fit bounds if we're not preserving zoom (i.e., on initial load or LGA change)
            if (!preserveZoom && DefaultDetails is null)
                await FitBounds();

            markersLoaded = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting up markers: {ex.Message}");
        }
    }

    private async Task ClearMarkers()
    {
        // First, dispose of marker clustering if it exists
        if (markerClustering is not null)
        {
            await markerClustering.ClearMarkers();
            await markerClustering.DisposeAsync();
            markerClustering = null;
        }

        // Then clear individual markers
        if (markers.Count > 0)
        {
            await Task.WhenAll(markers.Select(m => m.Value.SetMap(null)));
            foreach (KeyValuePair<FacilityCoords, AdvancedMarkerElement> marker in markers)
                marker.Value.Dispose();

            markers.Clear();
        }

        markersLoaded = false;
    }

    /// <summary>
    /// Helper to unpack the event data and call the main logic.
    /// </summary>
    private async Task HandleDragEnd(MouseEvent _, KeyValuePair<FacilityCoords, AdvancedMarkerElement> marker)
    {
        LatLngAltitudeLiteral newPosition = await marker.Value.GetPosition();
        FacilityCoords updatedCoords = marker.Key with
        {
            latitude = newPosition.Lat,
            longitude = newPosition.Lng
        };

        // Update the facilities array to reflect the new coordinates
        for (int i = 0; i < facilities.Length; i++)
        {
            if (facilities[i].Id == marker.Key.Id)
            {
                facilities[i] = updatedCoords;
                break;
            }
        }

        // Update the dictionary key by removing old entry and adding new one
        if (markers.Remove(marker.Key))
        {
            markers[updatedCoords] = marker.Value;
        }

        // Don't modify the DefaultCoord parameter - it's bound from parent
        // Just invoke the callback to notify parent of the change
        await OnUpdateCoords.InvokeAsync(updatedCoords);
    }

    /// <summary>
    /// When the marker is clicked, navigate to the facility details page
    /// </summary>
    private void OnMarkerClick(int facilityId) => _navigationManager.NavigateTo($"/Facilities/{facilityId}", true);

    /// <summary>
    /// The the map to fit the bounds of the markers
    /// </summary>
    /// <returns></returns>
    private async Task FitBounds()
    {
        if (await bounds.IsEmpty())
            return;

        LatLngBoundsLiteral boundsLiteral = await bounds.ToJson();
        await map!.InteropObject.FitBounds(boundsLiteral, OneOf.OneOf<int, Padding>.FromT0(5));
    }

    /// <summary>
    /// Releases all resources used by the object.
    /// </summary>
    /// <remarks>Call this method when you are finished using the object to free unmanaged resources and
    /// perform necessary cleanup. After calling <see cref="Dispose"/>, the object should not be used further. This
    /// method is safe to call multiple times; subsequent calls will have no effect.</remarks>
    public void Dispose()
    {
        foreach (KeyValuePair<FacilityCoords, AdvancedMarkerElement> marker in markers)
            marker.Value.Dispose();

        map?.Dispose();

        GC.SuppressFinalize(this);
    }
}