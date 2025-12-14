using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Casimo.Web.Helpers;
using GoogleMapsComponents;
using GoogleMapsComponents.Maps;
using GoogleMapsComponents.Maps.Coordinates;
using Microsoft.AspNetCore.Components;

namespace Casimo.Web.Components.Facilities;

/// <summary>
/// Extends the google maps component to show facility markers.
/// Shows a map of facilities with markers.
/// If supplied with a DefaultDetails parameter, shows only that facility in Single mode.
/// Otherwise shows all facilities in the selected LGA in All mode.
/// </summary>
public partial class CustomMap : IDisposable
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
    public FacilityDetailsDto? MainDetFac { get; set; }

    /// <summary>
    /// The show mode for the map. All or Single
    /// </summary>
    [Parameter]
    public required MapMode ShowMode { get; set; }

    /// <summary>
    /// If using a single facility, callback when coordinates are updated
    /// </summary>
    [Parameter]
    public EventCallback<FacilityCoords> OnUpdateCoords { get; set; }

    /// <summary>
    /// Event callback when a marker is clicked
    /// </summary>
    [Parameter]
    public EventCallback<int> OnMarkerClick { get; set; }

    /// <summary>
    /// This is used to indicate if the map is in the minimized view mode.
    /// </summary>
    [Parameter]
    public bool IsMinimizedView { get; set; }

    /// <summary>
    /// If the markers should be clickable to trigger OnMarkerClick
    /// </summary>
    [Parameter]
    public bool AllowMarkerClick { get; set; } = false;

    #region Private Fields
    private bool isLoading = false;

    /// <summary>
    /// Previous ShowMode to detect changes
    /// </summary>
    private MapMode? previousShowMode;

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
        // Set initial center - use DefaultDetails coordinates if available, otherwise use default
        LatLngLiteral initialCenter = new(-37.8162, 144.9640);
        if (MainDetFac is not null && MainDetFac.Coordinates is not null)
        {
            initialCenter = new LatLngLiteral(
                MainDetFac.Coordinates.Latitude ?? initialCenter.Lat,
                MainDetFac.Coordinates.Longitude ?? initialCenter.Lng
            );
        }

        string mapId = Guid.NewGuid().ToString();
        mapOptions = new()
        {
            Zoom = 13,
            Center = initialCenter,
            MapTypeId = MapTypeId.Satellite,
            MapId = Guid.NewGuid().ToString(),
            PanControl = false,
            CameraControl = false,
            FullscreenControl = false,
            ClickableIcons = false,
            Recycle = true,
            ZoomControl = true,
            ControlSize = 24
        };
        // Only reload LGAids if not already loaded
        if (lgaids.Length == 0)
        {
            Result<LGAidCounts[]> result = await _apiService.GetLgAids();
            lgaids = result.Value?.OrderByDescending(x => x.LGAidName).ToArray() ?? [];
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

        if (MainDetFac is not null && MainDetFac.Coordinates is not null)
            mapOptions!.Center = new LatLngLiteral(MainDetFac.Coordinates.Latitude ?? 0, MainDetFac.Coordinates.Longitude ?? 0);

        if ((previousShowMode != ShowMode || !markersLoaded) && !string.IsNullOrEmpty(selectedLGAid))
            await ValueChanged(selectedLGAid, true);

        previousShowMode = ShowMode;
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

        if (ShowMode is MapMode.Single && MainDetFac is not null)
            facilities = [.. facilities.Where(x => x.FacilityID == MainDetFac.FacilityId)];

        await LoadMapMarkersClustered(preserveZoom);
    }

    /// <summary>
    /// After the map has rendered, add markers for the facilities
    /// </summary>
    /// <param name="preserveZoom">If true, preserves the current zoom level by not calling FitBounds</param>
    /// <returns></returns>
    private async Task LoadMapMarkersClustered(bool preserveZoom = false, int callCount = 0)
    {
        try
        {
            if (facilities.Length == 0)
                return;

            if (map?.InteropObject is null)
            {
                Console.WriteLine("Map not loaded yet. Retrying...");
                await Task.Delay(500);
                if (callCount >= 3)
                {
                    Console.WriteLine("Max retries reached while loading map markers.");
                    return;
                }
                callCount++;
                await LoadMapMarkersClustered(preserveZoom, callCount);
            }

            if (map?.InteropObject is null)
                return;

            isLoading = true;
            await InvokeAsync(StateHasChanged);

            bounds = await LatLngBounds.CreateAsync(map.JsRuntime);

            List<(Task<AdvancedMarkerElement> MarkerTask, FacilityCoords Facility, LatLngLiteral Position)> markerData = [.. facilities.Select(facility =>
            {
                double lat = facility.latitude;
                LatLngLiteral latLng = new(lat, facility.longitude);
                bool isDefaultFacility = facility.FacilityID == MainDetFac?.FacilityId;
                string content = WebHelpers.CreateMapCoordinate(facility.Name, isDefaultFacility);
                Task<AdvancedMarkerElement> markerTask = AdvancedMarkerElement.CreateAsync(map.JsRuntime, new AdvancedMarkerElementOptions()
                {
                    Position = latLng,
                    Title = facility.Name,
                    Content = content,
                    GmpClickable = false,
                    GmpDraggable = isDefaultFacility && !IsMinimizedView
                });

                return (MarkerTask: markerTask, Facility: facility, Position: latLng);
            })];

            if (markers.Any(x => x.Key.FacilityID == MainDetFac?.FacilityId))
                markerData = [.. markerData.Where(x => x.Facility.FacilityID != MainDetFac?.FacilityId)];

            // Await all markers to be created
            AdvancedMarkerElement[] completedMarkers = await Task.WhenAll(markerData.Select(m => m.MarkerTask));

            // Extend bounds with all positions in parallel
            await Task.WhenAll(markerData.Select(m => bounds.Extend(m.Position)));

            // Build markers dictionary
            markers = completedMarkers
                .Zip(markerData, (marker, data) => (marker, data.Facility))
                .ToDictionary(x => x.Facility, x => x.marker);

            if (markerClustering is null)
            {
                // Create marker clustering
                markerClustering = await MarkerClustering.CreateAsync(
                    map.JsRuntime,
                    map.InteropObject,
                    markers.Values
                );
            }
            else
            {
                await markerClustering.AddMarkers(markers.Values);
            }
            // Add all event listeners in parallel
            List<Task> listenerTasks = new(markers.Count * 2);

            foreach (KeyValuePair<FacilityCoords, AdvancedMarkerElement> kvp in markers)
            {
                if (AllowMarkerClick)
                {
                    listenerTasks.Add(kvp.Value.AddListener("click", async () => await OnClickListener(kvp.Key.FacilityID)));
                }

                // Only add dragend listener for the default facility
                if (kvp.Key.FacilityID == MainDetFac?.FacilityId)
                    listenerTasks.Add(kvp.Value.AddListener<MouseEvent>("dragend", async (e) =>
                    {
                        await HandleDragEnd(e, kvp);
                    }));
            }

            await Task.WhenAll(listenerTasks);

            // Center the map appropriately based on the context
            if (!preserveZoom)
            {
                if (MainDetFac is not null && MainDetFac.Coordinates is not null)
                {
                    // Find the default facility marker position from the loaded markers
                    KeyValuePair<FacilityCoords, AdvancedMarkerElement> defaultMarker = markers.FirstOrDefault(m => m.Key.FacilityID == MainDetFac.FacilityId);

                    if (defaultMarker.Value != null)
                    {
                        // Get the actual marker position
                        LatLngAltitudeLiteral markerPosition = await defaultMarker.Value.GetPosition();
                        LatLngLiteral defaultPosition = new(markerPosition.Lat, markerPosition.Lng);

                        // Center on the default facility marker with appropriate zoom
                        await map.InteropObject.PanTo(defaultPosition);
                        await map.InteropObject.SetZoom(15); // Zoom in closer for individual marker
                    }
                    else
                    {
                        // Fallback to DefaultDetails coordinates if marker not found
                        LatLngLiteral defaultPosition = new(
                            MainDetFac.Coordinates.Latitude ?? 0,
                            MainDetFac.Coordinates.Longitude ?? 0
                        );
                        await map.InteropObject.PanTo(defaultPosition);
                        await map.InteropObject.SetZoom(15);
                    }
                }
                else
                {
                    // Fit bounds to show all markers
                    await FitBounds();
                }
            }

            markersLoaded = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting up markers: {ex.Message}");
        }
        finally
        {
            if (isLoading)
            {
                isLoading = false;
                await InvokeAsync(StateHasChanged);
            }
        }
    }

    /// <summary>
    /// Clears the markers fro mthe map
    /// </summary>
    /// <returns></returns>
    private async Task ClearMarkers()
    {
        // First, dispose of marker clustering if it exists
        if (markerClustering is not null)
        {
            await markerClustering.ClearMarkers(true);
            //markerClustering = null;
        }

        // Then clear individual markers
        if (markers.Count > 0)
        {
            await Task.WhenAll(markers.Select(m => m.Value.SetMap(null)));
            foreach (KeyValuePair<FacilityCoords, AdvancedMarkerElement> marker in markers)
            {
                // Keep the default facility marker if needed
                if (marker.Key.FacilityID == MainDetFac?.FacilityId)
                    continue;

                marker.Value.Dispose();
            }
            if (markers.Any(x => x.Key.FacilityID == MainDetFac?.FacilityId))
                markers = markers.Where(x => x.Key.FacilityID != MainDetFac?.FacilityId).ToDictionary(x => x.Key, x => x.Value);
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
            longitude = newPosition.Lng,
            FacilityID = marker.Key.FacilityID,
            Name = marker.Key.Name
        };

        // Update the facilities array to reflect the new coordinates
        for (int i = 0; i < facilities.Length; i++)
        {
            if (facilities[i].FacilityID == marker.Key.FacilityID)
            {
                facilities[i] = updatedCoords;
                break;
            }
        }

        // Update the dictionary key by removing old entry and adding new one
        if (markers.Remove(marker.Key))
            markers[updatedCoords] = marker.Value;

        // Don't modify the DefaultCoord parameter - it's bound from parent
        // Just invoke the callback to notify parent of the change
        await OnUpdateCoords.InvokeAsync(updatedCoords);
    }

    /// <summary>
    /// When the marker is clicked, navigate to the facility details page
    /// </summary>
    private async Task OnClickListener(int facilityId) => await InvokeAsync(() => OnMarkerClick.InvokeAsync(facilityId));

    /// <summary>
    /// The map to fit the bounds of the markers
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