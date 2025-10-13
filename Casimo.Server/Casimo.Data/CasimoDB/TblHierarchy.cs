using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblHierarchy
{
    /// <summary>
    /// Unique ID for the entry in the provision hierarchy
    /// </summary>
    public int HierarchyId { get; set; }

    /// <summary>
    /// Strategic hierarchy of provision (local, neighbourhood, district, regional)
    /// </summary>
    public string? Hierarchy { get; set; }

    /// <summary>
    /// Hierarchy of types
    /// </summary>
    public int? Order { get; set; }
}
