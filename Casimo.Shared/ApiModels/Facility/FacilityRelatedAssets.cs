namespace Casimo.Shared.ApiModels.Facility;

/// <summary>
/// Data transfer object for assets related to a facility
/// Contains information about equipment, infrastructure, and other assets associated with a facility
/// </summary>
public class FacilityRelatedAssets
{
    /// <summary>
    /// Gets or sets the reference identifier for the asset
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Gets or sets the alternative identifier for the asset
    /// </summary>
    public int AltId { get; set; }

    /// <summary>
    /// Gets or sets the current condition of the asset
    /// </summary>
    public string? Condition { get; set; }
}