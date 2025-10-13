using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwWorkerPopulationByForecastArea
{
    public int ForecastAreaBoundaryId { get; set; }

    public string? Area { get; set; }

    public short? Year { get; set; }

    public int? WorkerPopulation { get; set; }
}
