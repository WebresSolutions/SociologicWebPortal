using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPopulationByAggregatedAreaForAppend
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? CohortId { get; set; }

    public double? Year { get; set; }

    public double? Population { get; set; }

    public int? WorkerPopulation { get; set; }

    public double? TotalResidentPopulation { get; set; }

    public double? PercentTotalResPop { get; set; }
}
