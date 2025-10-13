using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwResidentPopulationByAggregatedAreaCreateTbl
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? CohortId { get; set; }

    public string? Cohort { get; set; }

    public double? Year { get; set; }

    public double? Population { get; set; }
}
