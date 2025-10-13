using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblForecastAreasCopy
{
    public int BoundaryId { get; set; }

    public string? Lgaid { get; set; }

    public string? BoundaryName { get; set; }

    public string? Suburb { get; set; }
}
