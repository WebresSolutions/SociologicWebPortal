using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ResponseModels;
using Casimo.Web.Helpers;
using GoogleMapsComponents;
using GoogleMapsComponents.Maps;
using GoogleMapsComponents.Maps.Coordinates;

namespace Casimo.Web.Components.Facilities;

public partial class MapView : IDisposable
{
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
    private List<AdvancedMarkerElement> markers = [];

    private MarkerClustering? markerClustering;
    /// <summary>
    /// Initial load of the component
    /// </summary>
    /// <returns></returns>
    protected override async Task OnParametersSetAsync()
    {
        Result<LGAidCounts[]> result = await _apiService.GetLgAids();
        lgaids = result.Value ?? [];
        StateHasChanged();
    }

    /// <summary>
    /// Initialize the map
    /// </summary>
    protected override void OnParametersSet() => mapOptions = new()
    {
        Zoom = 13,
        Center = new LatLngLiteral(-37.8162, 144.9640), // Default to Melbourne
        MapTypeId = MapTypeId.Roadmap,
        MapId = Guid.NewGuid().ToString()
    };

    /// <summary>
    /// Called when the selected LGAid changes
    /// </summary>
    /// <param name="lgAid">The lgaid</param>
    /// <returns></returns>
    private async Task ValueChanged(string lgAid)
    {
        selectedLGAid = lgAid;
        // Load the facilities now for the selected LGAid
        Result<FacilityCoords[]> facilitiesResult = await _apiService.GetFacilitesForLgAId(selectedLGAid);
        if (facilitiesResult.IsSuccess && facilitiesResult.Value is not null)
            facilities = facilitiesResult.Value;

        await ClearMarkers();

        if (facilities.Length > 100)
            await LoadMapMarkersClustered();
        else
            await LoadMapMarkers();
    }

    /// <summary>
    /// After the map has rendered, add markers for the facilities
    /// </summary>
    /// <returns></returns>
    private async Task LoadMapMarkersClustered()
    {
        try
        {
            if (map?.InteropObject is null)
                return;

            if (facilities.Length == 0)
                return;

            bounds = await LatLngBounds.CreateAsync(map.JsRuntime);
            List<Task<AdvancedMarkerElement>> markerTasks = new(facilities.Length);

            foreach (FacilityCoords facility in facilities)
            {
                double lat = facility.latitude;
                LatLngLiteral latLng = new(lat, facility.longitude);
                string content = WebHelpers.FormatCoordinate(facility.Name);

                Task<AdvancedMarkerElement> markerTask = AdvancedMarkerElement.CreateAsync(map.JsRuntime, new AdvancedMarkerElementOptions()
                {
                    Position = latLng,
                    Title = facility.Name,
                    Content = content,
                    GmpClickable = true
                });

                markerTasks.Add(markerTask);
                await bounds.Extend(latLng); // Extend bounds while other tasks run in parallel
            }

            // Wait for all markers to be created
            AdvancedMarkerElement[] createdMarkers = await Task.WhenAll(markerTasks);
            markers.AddRange(createdMarkers); // Add all created markers to the list

            // The MarkerClustering object is stored in a private field.
            markerClustering = await MarkerClustering.CreateAsync(map.JsRuntime, map.InteropObject, markers);

            List<Task> listenerTasks = new(createdMarkers.Length);
            for (int i = 0; i < createdMarkers.Length; i++)
            {
                AdvancedMarkerElement marker = createdMarkers[i];
                FacilityCoords facility = facilities[i];

                // Add listener without awaiting
                listenerTasks.Add(marker.AddListener("OnClick", () => OnMarkerClick(facility.Id)));
            }

            // Wait for all listeners to be attached (Optional, but good practice)
            await Task.WhenAll(listenerTasks);
            await FitBounds();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error setting up markers: {ex.Message}");
        }
    }

    /// <summary>
    /// After the map has rendered, add markers for the facilities
    /// </summary>
    /// <returns></returns>
    private async Task LoadMapMarkers()
    {
        try
        {
            if (map?.InteropObject is null)
                return;

            if (facilities.Length == 0)
                return;

            bounds = await LatLngBounds.CreateAsync(map.JsRuntime);
            List<Task<AdvancedMarkerElement>> markerTasks = new(facilities.Length);

            foreach (FacilityCoords facility in facilities)
            {
                double lat = facility.latitude;
                double lng = facility.longitude;
                LatLngLiteral latLng = new(lat, lng);
                string content = WebHelpers.FormatCoordinate(facility.Name);

                Task<AdvancedMarkerElement> markerTask = AdvancedMarkerElement.CreateAsync(map.JsRuntime, new AdvancedMarkerElementOptions()
                {
                    Position = latLng,
                    Title = facility.Name,
                    Content = content,
                    GmpClickable = true
                });
                markerTasks.Add(markerTask);
                await bounds.Extend(latLng);
            }

            AdvancedMarkerElement[] createdMarkers = await Task.WhenAll(markerTasks);
            markers.AddRange(createdMarkers);

            // Store the MarkerClustering instance so it can be disposed later
            markerClustering = await MarkerClustering.CreateAsync(map.JsRuntime, map.InteropObject, markers);

            List<Task> listenerTasks = [];
            for (int i = 0; i < createdMarkers.Length; i++)
            {
                AdvancedMarkerElement marker = createdMarkers[i];
                FacilityCoords facility = facilities[i];
                listenerTasks.Add(marker.AddListener("OnClick", () => OnMarkerClick(facility.Id)));
            }

            await Task.WhenAll(listenerTasks);
            await FitBounds();
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
            await Task.WhenAll(markers.Select(m => m.SetMap(null)));
            foreach (AdvancedMarkerElement marker in markers)
            {
                marker.Dispose();
            }
            markers.Clear();
        }
    }

    /// <summary>
    /// When the marker is clicked, navigate to the facility details page
    /// </summary>
    private void OnMarkerClick(int facilityId) => _navigationManager.NavigateTo($"/Facilities/{facilityId}");

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
        foreach (AdvancedMarkerElement marker in markers)
            marker.Dispose();

        map?.Dispose();

        GC.SuppressFinalize(this);
    }
}