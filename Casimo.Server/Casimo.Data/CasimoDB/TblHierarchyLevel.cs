using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblHierarchyLevel
{
    public int HierarchyLevelId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public int? HierarchyNameId { get; set; }

    public string? HierarchyLevel { get; set; }

    public int? Order { get; set; }

    public virtual TblHierarchyName? HierarchyName { get; set; }
}
