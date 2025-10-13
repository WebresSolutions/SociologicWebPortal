using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwWorkerPopulationByAggregeatedArea
{
    public int? AggrBoundaryId { get; set; }

    public short? Year { get; set; }

    public int? WorkerPopulation { get; set; }
}
