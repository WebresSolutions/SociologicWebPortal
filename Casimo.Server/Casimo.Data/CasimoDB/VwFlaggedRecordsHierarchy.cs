using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFlaggedRecordsHierarchy
{
    public int? FacilityId { get; set; }

    public int ServiceId { get; set; }

    public int? HierarchyNameId { get; set; }

    public int HierarchyLevelId { get; set; }

    public string? Type { get; set; }
}
