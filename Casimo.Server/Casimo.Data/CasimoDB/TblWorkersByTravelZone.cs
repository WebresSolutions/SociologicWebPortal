using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblWorkersByTravelZone
{
    public int Id { get; set; }

    public string? TravelZoneId { get; set; }

    public string? Type { get; set; }

    public int? Year { get; set; }

    public int? Number { get; set; }
}
