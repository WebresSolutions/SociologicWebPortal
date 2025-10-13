using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Description of each service/activity delivered through each facility and the relevant service class, infrastructure class and infrastructure type under the typology.
/// </summary>
public partial class TblService
{
    /// <summary>
    /// Unique ID for the service delivered through the linked facility
    /// </summary>
    public int ServiceId { get; set; }

    /// <summary>
    /// Lookup to tblFacilities
    /// </summary>
    public int? FacilityId { get; set; }

    /// <summary>
    /// Lookup to tblInfType
    /// </summary>
    public int? InfTypeId { get; set; }

    /// <summary>
    /// Optional additional description of the item of infrastructure
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Lookup to tblAccessType
    /// </summary>
    public int? AccessTypeId { get; set; }

    /// <summary>
    /// Lookup to tblServiceOwners
    /// </summary>
    public string? ServiceOwner { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public int? TempId { get; set; }

    public byte[]? Ts { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }

    public virtual TblAccessType? AccessType { get; set; }

    public virtual TblInfType? InfType { get; set; }
}
