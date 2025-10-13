using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAssetsByFacility
{
    public int FacilityId { get; set; }

    public string? AssetRef { get; set; }

    public string? Lgaid { get; set; }
}
