using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwForecastAreaAllCombination
{
    public string? Area { get; set; }

    public int BoundaryId { get; set; }

    public int? CohortId { get; set; }

    public int QtyAssessmentStdId { get; set; }

    public string? StdName { get; set; }

    public int PopRatioStdId { get; set; }

    public string? PopRatioStdsLgaid { get; set; }

    public decimal? TargetUnits { get; set; }

    public decimal? TargetPop { get; set; }

    public decimal? TriggerPop { get; set; }

    public string? Rationale { get; set; }

    public int? UnitTypeId { get; set; }

    public string? BoundaryLgaid { get; set; }

    public string? QtyAssessmentStdsLgaid { get; set; }
}
