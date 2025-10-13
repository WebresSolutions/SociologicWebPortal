using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Casimo.Shared.ApiModels.Facility;

/// <summary>
/// Detailed facility information data transfer object
/// Contains comprehensive facility details including location, ownership, and operational information
/// </summary>
public class FacilityDetailsDto
{
    /// <summary>
    /// Initializes a new instance of the FacilityDetailsDto class
    /// Default constructor for serialization purposes
    /// </summary>
    public FacilityDetailsDto()
    {
    }

    /// <summary>
    /// Initializes a new instance of the FacilityDetailsDto class with specified values
    /// </summary>
    /// <param name="facilityId">The unique identifier for the facility</param>
    /// <param name="siteName">The name of the facility site</param>
    /// <param name="streetAddress">The street address of the facility</param>
    /// <param name="postCode">The postal code for the facility location</param>
    /// <param name="suburb">The suburb or locality where the facility is located</param>
    /// <param name="owner">The type or name of the facility owner</param>
    /// <param name="oper">The name of the facility operator</param>
    /// <param name="status">The current operational status of the facility</param>
    /// <param name="coordinates">The geographic coordinates of the facility</param>
    /// <param name="notes">Optional notes about the facility</param>
    [SetsRequiredMembers]
    public FacilityDetailsDto(int facilityId, string siteName, string streetAddress, short? postCode, string suburb, string owner, string oper, string status, Coordinates? coordinates, string? notes, int? statusId)
    {
        FacilityId = facilityId;
        SiteName = siteName;
        StreetAddress = streetAddress;
        PostCode = postCode;
        Suburb = suburb;
        Owner = owner;
        Operator = oper;
        Status = status;
        Coordinates = coordinates;
        Notes = notes;
        StatusId = statusId;
    }

    /// <summary>
    /// Gets or sets the unique identifier for the facility
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Gets or sets the name of the facility site
    /// </summary>
    [MaxLength(150)]
    [Required]
    public string SiteName { get; set; }

    /// <summary>
    /// Gets or sets the street address of the facility
    /// </summary>
    [MaxLength(150)]
    [Required]
    public string StreetAddress { get; set; }

    /// <summary>
    /// Gets or sets the postal code for the facility location
    /// </summary>
    [Range(0, 9999)]
    public short? PostCode { get; set; }

    /// <summary>
    /// Gets or sets the suburb or locality where the facility is located
    /// </summary>
    [MaxLength(150)]
    [Required]
    public string Suburb { get; set; }

    /// <summary>
    /// Gets or sets the type or name of the facility owner
    /// </summary>
    [MaxLength(150)]
    [Required]
    public string Owner { get; set; }

    /// <summary>
    /// Gets or sets the name of the facility operator
    /// </summary>
    [MaxLength(150)]
    [Required]
    public string Operator { get; set; }

    /// <summary>
    /// Gets or sets the current operational status of the facility
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// The status Id
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// Gets or sets optional notes about the facility
    /// </summary>
    [MaxLength(4096)]
    public string? Notes { get; set; }

    /// <summary>
    /// Gets or sets the geographic coordinates of the facility
    /// </summary>
    public Coordinates? Coordinates { get; set; }
}