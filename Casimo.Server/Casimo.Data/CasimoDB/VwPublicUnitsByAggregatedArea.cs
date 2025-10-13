using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPublicUnitsByAggregatedArea
{
    public string? Area { get; set; }

    public int? InfTypeId { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? SumQuantity { get; set; }

    public string? Settlement { get; set; }

    public int? ActiveFrom { get; set; }

    public decimal? PublicUnits { get; set; }
}
