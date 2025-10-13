using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwResidentPopulationByAggregatedForecastArea
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? CohortId { get; set; }

    public double? Year { get; set; }

    public double? ForecastAreaPopulation { get; set; }

    public string? ForecastArea { get; set; }
}
