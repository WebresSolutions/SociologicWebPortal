using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TmptblPopulationForecastByCohortAndYear
{
    public string? Area { get; set; }

    public int? BoundaryId { get; set; }

    public double? Year { get; set; }

    public int? CohortId { get; set; }

    public string? Cohort { get; set; }

    public string? Gender { get; set; }

    public double? ForecastAreaCohortPopulation { get; set; }

    public string? Lgaid { get; set; }
}
