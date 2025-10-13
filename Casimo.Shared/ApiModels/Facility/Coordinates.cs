namespace Casimo.Shared.ApiModels.Facility;

/// <summary>
/// Represents geographic coordinates with latitude and longitude values
/// Used for mapping and location-based functionality
/// </summary>
public class Coordinates
{
    /// <summary>
    /// Initializes a new instance of the Coordinates class
    /// </summary>
    public Coordinates()
    {
    }

    /// <summary>
    /// Initializes a new instance of the Coordinates class with specified latitude and longitude
    /// </summary>
    /// <param name="latitude">The latitude coordinate value</param>
    /// <param name="longitude">The longitude coordinate value</param>
    public Coordinates(double? latitude, double? longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    /// Gets or sets the latitude coordinate value
    /// Positive values indicate North, negative values indicate South
    /// </summary>
    public double? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude coordinate value
    /// Positive values indicate East, negative values indicate West
    /// </summary>
    public double? Longitude { get; set; }
}