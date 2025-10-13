using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwInfTypeByLga
{
    public int InfTypeId { get; set; }

    public string Lgaid { get; set; } = null!;

    public string? Type { get; set; }

    public string? Definition { get; set; }

    public int? DefaultCohortId { get; set; }

    public int? DefaultUnitTypeId { get; set; }
}
