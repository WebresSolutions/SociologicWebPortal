using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Attribute information for facilities (note, information on services, activities or infrastructure type provided through the facility are stored in tblServices)
/// </summary>
public partial class TblFacility
{
    /// <summary>
    /// Unique ID for each facility
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// Facility ID of parent facility where current facility is a child (not required)
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// 4 digit UserID of the user that first created the record
    /// </summary>
    public int? CreatorUserId { get; set; }

    /// <summary>
    /// Existing, planned, hypothetical
    /// </summary>
    public int? StatusId { get; set; }

    /// <summary>
    /// Earliest year that facility should be included in modelling
    /// </summary>
    public int? ActiveFrom { get; set; }

    public int? ActiveUntil { get; set; }

    /// <summary>
    /// Name of the overall facility or site
    /// </summary>
    public string? FacilitySite { get; set; }

    /// <summary>
    /// A specific component of the overall facility. Different components are usually spatially separate from each other.
    /// </summary>
    public string? FacilityComponent { get; set; }

    /// <summary>
    /// Street number and name
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Settlement name (this may be town, suburb or locality)
    /// </summary>
    public string? Settlement { get; set; }

    /// <summary>
    /// Postcode
    /// </summary>
    public short? Postcode { get; set; }

    /// <summary>
    /// Landowner name
    /// </summary>
    public string? Owner { get; set; }

    /// <summary>
    /// Facility operator / manager name
    /// </summary>
    public string? Operator { get; set; }

    /// <summary>
    /// Ownership or financial interest in the facility
    /// </summary>
    public int? UserInterestId { get; set; }

    /// <summary>
    /// General comments about the facility
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// X coordinates (GDA94) longitude for link to GIS
    /// </summary>
    public double? XLongitude { get; set; }

    /// <summary>
    /// Y coordinates (GDA94) latitude for link to GIS
    /// </summary>
    public double? YLatitude { get; set; }

    public bool? CoordsCorrectLga { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public int? TempId { get; set; }

    public bool IsLocked { get; set; }

    public int? LockedByUser { get; set; }

    public virtual TblUser? CreatorUser { get; set; }

    public virtual TblFacilityStatus? Status { get; set; }

    public virtual ICollection<TblAsset> TblAssets { get; set; } = new List<TblAsset>();

    public virtual TblUserInterest? UserInterest { get; set; }
}
