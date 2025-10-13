using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblWorkerZonesForecastArea
{
    public int? WorkerZoneId { get; set; }

    public string? TravelZone { get; set; }

    public int ForecastAreaBoundaryId { get; set; }

    public string? ForecastAreaLgaid { get; set; }

    public string? ForecastAreaBoundaryName { get; set; }
}
