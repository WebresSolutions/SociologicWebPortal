using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCasimoQuantityAsstStandard
{
    public int UniqueRecordId { get; set; }

    public string? StandardName { get; set; }

    public string? UnitType { get; set; }

    public string? PopulationStandard { get; set; }

    public string? Rationale { get; set; }

    public string? CasimoLgaName { get; set; }
}
