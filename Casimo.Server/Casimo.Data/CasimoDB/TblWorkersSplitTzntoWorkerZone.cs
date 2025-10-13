using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblWorkersSplitTzntoWorkerZone
{
    public int Id { get; set; }

    public string? TznToSplit { get; set; }

    public string? Type { get; set; }

    public double? ToWorkerZone { get; set; }

    public double? SplitPercent { get; set; }

    public byte[]? UpsizeTs { get; set; }
}
