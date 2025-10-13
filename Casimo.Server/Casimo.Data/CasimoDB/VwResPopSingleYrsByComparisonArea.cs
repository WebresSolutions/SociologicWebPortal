using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwResPopSingleYrsByComparisonArea
{
    public string? Lgaid { get; set; }

    public string? CasimoUserName { get; set; }

    public int CombinedAreaId { get; set; }

    public string? CombinedAreaName { get; set; }

    public double? AgeGroup { get; set; }

    public string? Gender { get; set; }

    public double? Year { get; set; }

    public double? Population { get; set; }

    public int CasimoUserId { get; set; }
}
