using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwWorkerPopulationByAggregeatedForecastArea
{
    public int? AggrBoundaryId { get; set; }

    public short? Year { get; set; }

    public int? ForecastAreaWorkerPopulation { get; set; }

    public string? ForecastArea { get; set; }
}
