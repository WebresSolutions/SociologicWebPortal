using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwInfTypeUnit
{
    public int InfTypeUnitId { get; set; }

    public int? InfTypeId { get; set; }

    public int? UnitTypeId { get; set; }

    public string? Lgaid { get; set; }

    public string? UnitType { get; set; }
}
