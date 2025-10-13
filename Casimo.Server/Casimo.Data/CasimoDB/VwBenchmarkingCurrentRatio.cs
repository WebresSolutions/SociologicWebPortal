using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwBenchmarkingCurrentRatio
{
    public string Lgaid { get; set; } = null!;

    public string? AreaName { get; set; }

    public string? BenchmarkTitle { get; set; }

    public string? BenchmarkTitleFull { get; set; }

    public string? ShortUse { get; set; }

    public string? ShortTitle { get; set; }

    public double? BenchmarkRatio { get; set; }

    public string? UnitType { get; set; }

    public string? Cohort { get; set; }

    public string? Rationale { get; set; }
}
