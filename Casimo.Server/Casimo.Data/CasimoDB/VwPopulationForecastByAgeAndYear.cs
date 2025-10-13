using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPopulationForecastByAgeAndYear
{
    public int Id { get; set; }

    public string? Area { get; set; }

    public double? Year { get; set; }

    public int? CohortId { get; set; }

    public double? AgeGroup { get; set; }

    public string? Gender { get; set; }

    public double? Number { get; set; }

    public string? Lgaid { get; set; }
}
