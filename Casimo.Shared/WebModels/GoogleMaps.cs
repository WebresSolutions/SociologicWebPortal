namespace Casimo.Shared.WebModels;

/// <summary>
/// Configuration class for Google Maps integration
/// Contains settings required for Google Maps API functionality
/// </summary>
public class GoogleMaps
{
    /// <summary>
    /// Gets or sets the Google Maps API key required for map functionality
    /// This key must be valid and have the appropriate permissions enabled
    /// </summary>
    public string MapsApiKey { get; init; } = string.Empty;
}