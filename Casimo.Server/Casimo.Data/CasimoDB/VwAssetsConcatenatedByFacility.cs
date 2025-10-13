using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAssetsConcatenatedByFacility
{
    public int FacilityId { get; set; }

    public string? AssetRefs { get; set; }
}
