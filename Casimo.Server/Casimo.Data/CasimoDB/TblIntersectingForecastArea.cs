using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblIntersectingForecastArea
{
    public int FromBoundaryId { get; set; }

    public string? FromBoundaryName { get; set; }

    public string? FromBoundaryLgaid { get; set; }

    public int ToBoundaryId { get; set; }

    public string ToBoundaryName { get; set; } = null!;

    public string? ToBoundaryLgaid { get; set; }
}
