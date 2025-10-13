using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwInfGroupClassTypeByLgawithQtyStandard
{
    public int InfTypeId { get; set; }

    public string? InfType { get; set; }

    public string? Lgaid { get; set; }

    public string? FacilityLgaid { get; set; }

    public int? DefaultCohortId { get; set; }
}
