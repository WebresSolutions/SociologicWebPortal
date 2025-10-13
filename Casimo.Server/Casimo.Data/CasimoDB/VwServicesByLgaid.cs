using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwServicesByLgaid
{
    public int ServiceId { get; set; }

    public int? FacilityId { get; set; }

    public int? InfTypeId { get; set; }

    public string? Description { get; set; }

    public int? AccessTypeId { get; set; }

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

    public string? Lgaid { get; set; }

    public int? StatusId { get; set; }

    public int? ActiveFrom { get; set; }

    public string? FacilitySite { get; set; }

    public string? FacilityComponent { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public string? Owner { get; set; }

    public string? Operator { get; set; }

    public int? UserInterestId { get; set; }

    public string? Comments { get; set; }

    public double? XLongitude { get; set; }

    public double? YLatitude { get; set; }
}
