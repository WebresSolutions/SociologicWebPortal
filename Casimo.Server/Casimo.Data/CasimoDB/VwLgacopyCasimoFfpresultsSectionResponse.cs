using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwLgacopyCasimoFfpresultsSectionResponse
{
    public string? UniqueRecordId { get; set; }

    public int CasimoFacilityId { get; set; }

    public string? FacilityNameFull { get; set; }

    public string? FacilityNameSite { get; set; }

    public string? FacilityNameComponent { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public string? Owner { get; set; }

    public string? Operator { get; set; }

    public double? LongitudeX { get; set; }

    public double? LatitudeY { get; set; }

    public string? CouncilAssetRef { get; set; }

    public string? FfpAssessedUse { get; set; }

    public string FfpTemplate { get; set; } = null!;

    public string? FfpCategory { get; set; }

    public string? FfpCategorySummary { get; set; }

    public decimal CategoryScore { get; set; }

    public string? CategoryRating { get; set; }

    public decimal CategoryScore2 { get; set; }

    public string? CategoryRating2 { get; set; }

    public string CustomGroups { get; set; } = null!;

    public string? CasimoLgaName { get; set; }

    public string CasimoLgaId { get; set; } = null!;

    public int CasimoFfplogId { get; set; }

    public string? AssetCondition { get; set; }
}
