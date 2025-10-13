using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwBenchmarkingComparisonRatio
{
    public string Lgaid { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string? BenchmarkTitle { get; set; }

    public string? BenchmarkTitleFull { get; set; }

    public string? ShortUse { get; set; }

    public string? ShortTitle { get; set; }

    public decimal? BenchmarkRatio { get; set; }

    public string? UnitType { get; set; }

    public string? Cohort { get; set; }

    public string? Rationale { get; set; }
}
