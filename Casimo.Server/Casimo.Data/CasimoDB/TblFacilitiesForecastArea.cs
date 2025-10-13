using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFacilitiesForecastArea
{
    public int FacilityId { get; set; }

    public string? FacilitySite { get; set; }

    public int ForecastAreaBoundaryId { get; set; }

    public string? ForecastAreaLgaid { get; set; }

    public string? ForecastAreaBoundaryName { get; set; }
}
