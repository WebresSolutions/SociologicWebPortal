using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwQtyStandard
{
    public int PopRatioStdId { get; set; }

    public int InfTypeId { get; set; }

    public string? InfType { get; set; }

    public string? Lgaid { get; set; }

    public string? FacilityLgaid { get; set; }

    public int? DefaultCohortId { get; set; }

    public int? UnitTypeId { get; set; }

    public string? UnitType { get; set; }
}
