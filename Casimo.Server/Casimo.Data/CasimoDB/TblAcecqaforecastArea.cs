using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAcecqaforecastArea
{
    public string ServiceApprovalNumber { get; set; } = null!;

    public string? ServiceName { get; set; }

    public int ForecastAreaBoundaryId { get; set; }

    public string? ForecastAreaLgaid { get; set; }

    public string? ForecastAreaBoundaryName { get; set; }
}
