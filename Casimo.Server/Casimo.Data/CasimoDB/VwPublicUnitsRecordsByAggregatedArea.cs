using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPublicUnitsRecordsByAggregatedArea
{
    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int? InfTypeId { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? SumQuantity { get; set; }

    public int? ActiveFrom { get; set; }

    public decimal? PublicUnits { get; set; }

    public string? UserLgaid { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }

    public string? Lgaid { get; set; }
}
