using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPublicUnitsSumByAggregatedArea
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? PublicUnits { get; set; }

    public double? ActualYear { get; set; }

    public int QtyAssessmentStdId { get; set; }
}
