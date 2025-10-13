using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFacilitiesUsesQuantitiesForGi
{
    public int? FacilityId { get; set; }

    public string? Lganame { get; set; }

    public string? FacilityStatus { get; set; }

    public int? ActiveFrom { get; set; }

    public string? FacilityNameFull { get; set; }

    public string? FacilitySite { get; set; }

    public string? FacilityComponent { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public string? Owner { get; set; }

    public string? Operator { get; set; }

    public string? Comments { get; set; }

    public string? RelatedUseComment { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? AssetRef { get; set; }

    public string? Additionalident { get; set; }

    public string? Type { get; set; }

    public int InfTypeId { get; set; }

    public string? AccessType { get; set; }

    public string? AccessTypeDescription { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitType { get; set; }

    public string? Lgaid { get; set; }

    public int ServiceId { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public string? InfTypeHierarchyAttributes { get; set; }

    public double? XLongitude { get; set; }

    public double? YLatitude { get; set; }
}
