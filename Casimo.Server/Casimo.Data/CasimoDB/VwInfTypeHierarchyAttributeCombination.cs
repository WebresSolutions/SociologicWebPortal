using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwInfTypeHierarchyAttributeCombination
{
    public string Lgaid { get; set; } = null!;

    public int InfTypeId { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public int? UnitTypeId { get; set; }

    public int? DefaultCohortId { get; set; }

    public string? InfTypeHierarchyAttributes { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }
}
