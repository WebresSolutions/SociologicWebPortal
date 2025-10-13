using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwResidentTotalPopulationByForecastArea
{
    public string? Area { get; set; }

    public int? CohortId { get; set; }

    public double? Year { get; set; }

    public double? TotalResidentPopulation { get; set; }

    public string? Lgaid { get; set; }
}
