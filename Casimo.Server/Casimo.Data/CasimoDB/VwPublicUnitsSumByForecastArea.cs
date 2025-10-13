using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPublicUnitsSumByForecastArea
{
    public string? Area { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? PublicUnits { get; set; }

    public double? ActualYear { get; set; }

    public string? Lgaid { get; set; }

    public int BoundaryId { get; set; }

    public int QtyAssessmentStdId { get; set; }
}
