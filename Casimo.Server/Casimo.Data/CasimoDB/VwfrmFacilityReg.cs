using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwfrmFacilityReg
{
    public int? FacilityId { get; set; }

    public int? ParentId { get; set; }

    public string? Lgaid { get; set; }

    public int? CreatorUserId { get; set; }

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

    public int ServiceId { get; set; }

    public int? InfTypeId { get; set; }

    public string? Description { get; set; }

    public int? AccessTypeId { get; set; }

    public string? ServiceOwner { get; set; }

    public string? InfType { get; set; }

    public decimal? Quantity { get; set; }

    public bool? CoordsCorrectLga { get; set; }

    public int FlaggedRecordHierarchy { get; set; }

    public int FlaggedRecordAttribute1 { get; set; }

    public int FlaggedRecordAttribute2 { get; set; }

    public int? CustomUseGroupId { get; set; }

    public string? CustomUseGroupName { get; set; }
}
