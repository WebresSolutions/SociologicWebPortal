using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwLgacopyCasimofacilitiesUsesQuantity
{
    public string? UniqueRecordId { get; set; }

    public int? CasimoFacilityId { get; set; }

    public string? FacilityStatus { get; set; }

    public int? ActiveFromYear { get; set; }

    public string? FacilityNameFull { get; set; }

    public string? FacilityNameSite { get; set; }

    public string? FacilityNameComponent { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public string? Owner { get; set; }

    public string? Operator { get; set; }

    public string? CouncilContactPerson { get; set; }

    public string? FacilityNotes { get; set; }

    public string? RelatedUseNotes { get; set; }

    public double? LongitudeX { get; set; }

    public double? LatitudeY { get; set; }

    public string? CouncilAssetRef { get; set; }

    public string? AlternativeIdentifier { get; set; }

    public string? UseHierarchyAttribute { get; set; }

    public string? AccessType { get; set; }

    public decimal? Quantity { get; set; }

    public string? UnitType { get; set; }

    public string? CasimoLgaName { get; set; }

    public string? CasimoLgaId { get; set; }

    public int CasimoUseId { get; set; }

    public int? CasimoUnitTypeId { get; set; }

    public string? Use { get; set; }

    public string CustomGroups { get; set; } = null!;

    public DateTime? DateLastUpdated { get; set; }
}
