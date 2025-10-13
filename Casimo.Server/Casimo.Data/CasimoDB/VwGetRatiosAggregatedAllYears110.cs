using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwGetRatiosAggregatedAllYears110
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public double? Year { get; set; }

    public int QtyAssessmentStdId { get; set; }

    public int? CohortId { get; set; }

    public string? Cohort { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? PublicUnits { get; set; }

    public double? Population { get; set; }

    public string? AggrAreaUserLgaid { get; set; }

    public string? PopRatioStdsLgaid { get; set; }

    public int PopRatioStdId { get; set; }

    public decimal? TargetUnits { get; set; }

    public decimal? Targetpop { get; set; }

    public decimal? TriggerPop { get; set; }

    public string? UnitType { get; set; }

    public int? Rounding { get; set; }

    public string? Rationale { get; set; }

    public int? UserId { get; set; }
}
