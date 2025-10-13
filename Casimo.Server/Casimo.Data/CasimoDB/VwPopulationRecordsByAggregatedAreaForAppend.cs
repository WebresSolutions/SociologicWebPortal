using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPopulationRecordsByAggregatedAreaForAppend
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? CohortId { get; set; }

    public double? Year { get; set; }

    public double? Population { get; set; }

    public string? Area { get; set; }

    public string? Lgaid { get; set; }
}
