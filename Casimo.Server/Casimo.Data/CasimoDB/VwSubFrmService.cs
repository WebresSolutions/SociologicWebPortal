using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwSubFrmService
{
    public int? FacilityId { get; set; }

    public int ServiceId { get; set; }

    public string? Type { get; set; }

    public string? LocalName { get; set; }

    public string? AccessType { get; set; }

    public string? ServiceOwner { get; set; }

    public string? Description { get; set; }

    public int? InfTypeId { get; set; }

    public string? HierarchyLevel { get; set; }

    public string? Attribute1 { get; set; }

    public string? Attribute2 { get; set; }

    public string? InfTypeHierarchyAttributes { get; set; }
}
