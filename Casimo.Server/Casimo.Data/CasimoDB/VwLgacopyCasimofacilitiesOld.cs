using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwLgacopyCasimofacilitiesOld
{
    public int UniqueRecordId { get; set; }

    public int CasimoFacilityId { get; set; }

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

    public string? FacilityNotes { get; set; }

    public double? LongitudeX { get; set; }

    public double? LatitudeY { get; set; }

    public string? CouncilAssetRef { get; set; }

    public string? AlternativeIdentifier { get; set; }

    public string? CasimoLgaName { get; set; }

    public string CasimoLgaId { get; set; } = null!;

    public DateTime? DateLastUpdated { get; set; }
}
