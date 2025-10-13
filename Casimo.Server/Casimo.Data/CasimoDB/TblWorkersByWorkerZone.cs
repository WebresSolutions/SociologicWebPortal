using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblWorkersByWorkerZone
{
    public int Id { get; set; }

    public int? WorkerZoneId { get; set; }

    public string? Type { get; set; }

    public short? Year { get; set; }

    public short? Number { get; set; }
}
