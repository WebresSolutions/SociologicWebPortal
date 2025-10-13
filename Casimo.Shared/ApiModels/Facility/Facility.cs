namespace Casimo.Shared.ApiModels.Facility;

/// <summary>
/// Data transfer object for facility list items
/// Contains basic facility information for display in lists and grids
/// </summary>
public class FacilityListItemDto
{
    /// <summary>
    /// Gets or sets the unique identifier for the facility
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Gets or sets the name of the facility site
    /// </summary>
    public string? SiteName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the street address of the facility
    /// </summary>
    public string? Address { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the settlement or locality where the facility is located
    /// </summary>
    public string? Settlement { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the postal code for the facility location
    /// </summary>
    public short? PostCode { get; set; }

    /// <summary>
    /// Gets or sets the name of the facility owner
    /// </summary>
    public string? Owner { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the facility operator
    /// </summary>
    public string? Operator { get; set; } = string.Empty;

    public string LgAid { get; set; } = string.Empty;
}