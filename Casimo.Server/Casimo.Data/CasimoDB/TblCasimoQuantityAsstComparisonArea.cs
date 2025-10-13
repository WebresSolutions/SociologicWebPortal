using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCasimoQuantityAsstComparisonArea
{
    public double UniqueRecordId { get; set; }

    public string? ComparisonArea { get; set; }

    public string? QuantityStandard { get; set; }

    public double? Year { get; set; }

    public double? ExistingQuantity { get; set; }

    public double? TargetQuantity { get; set; }

    public double? Difference { get; set; }

    public double? Difference1 { get; set; }

    public string? AgeCohort { get; set; }

    public double? CohortSize { get; set; }

    public string? CurrentRatio { get; set; }

    public string? TargetRatio { get; set; }

    public string? CasimoLgaName { get; set; }

    public int? ForecastAreaId { get; set; }

    public string? ComponentForecastAreas { get; set; }

    public string? CasimoUserName { get; set; }
}
