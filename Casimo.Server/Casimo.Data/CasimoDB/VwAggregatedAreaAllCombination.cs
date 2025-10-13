using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAggregatedAreaAllCombination
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? CohortId { get; set; }

    public string? AggrAreaUserLgaid { get; set; }

    public int PopRatioStdId { get; set; }

    public string? PopRatioStdsLgaid { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? TargetUnits { get; set; }

    public decimal? TargetPop { get; set; }

    public decimal? TriggerPop { get; set; }

    public string? Rationale { get; set; }

    public int? UserId { get; set; }

    public string? QtyAssessmentStdsLgaid { get; set; }

    public int QtyAssessmentStdId { get; set; }
}
