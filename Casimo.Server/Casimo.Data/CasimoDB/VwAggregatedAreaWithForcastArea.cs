using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAggregatedAreaWithForcastArea
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public string? ForecastAreaLgaid { get; set; }

    public string? ForecastAreaBoundaryName { get; set; }

    public int ForecastAreaBoundaryId { get; set; }
}
