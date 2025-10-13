using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwInfTypeHierarchyLevelsAttribute
{
    public int InfTypeId { get; set; }

    public string Lgaid { get; set; } = null!;

    public int? HierarchyNameId { get; set; }

    public int? AttributeName1Id { get; set; }

    public int? AttributeName2Id { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }

    public string? InfTypeHierarchyAttributes { get; set; }
}
