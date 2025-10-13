using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAggrBoundaryForecastArea
{
    public int AggrBoundaryForecastAreaId { get; set; }

    public int? AggrBoundaryId { get; set; }

    public int? ForecastAreaBoundaryId { get; set; }
}
