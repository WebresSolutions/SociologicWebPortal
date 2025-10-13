using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwResidentTotalPopulationByAggregatedArea
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public double? Year { get; set; }

    public double? TotalResidentPopulation { get; set; }
}
