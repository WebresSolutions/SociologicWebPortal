using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFlaggedRecordsUnitQuantity
{
    public decimal? Quantity { get; set; }

    public int? FacilityId { get; set; }

    public string? UnitType { get; set; }

    public string? Type { get; set; }
}
