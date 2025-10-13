using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwQtyAssessmentStdsId
{
    public int Id { get; set; }

    public int QtyAssessmentStdId { get; set; }

    public int InfTypeId { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }

    public string? Type { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribut2 { get; set; }

    public string? InfTypeHierarchyAttributes { get; set; }
}
