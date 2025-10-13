using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwPublicUnitsRecordsByForecastArea
{
    public string? Area { get; set; }

    public int? InfTypeId { get; set; }

    public int? UnitTypeId { get; set; }

    public int? ActiveFrom { get; set; }

    public decimal PublicUnits { get; set; }

    public int FacilityId { get; set; }

    public string? ForecastAreaLgaid { get; set; }

    public string? Lgaid { get; set; }

    public int? AccessTypeId { get; set; }

    public int BoundaryId { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }
}
