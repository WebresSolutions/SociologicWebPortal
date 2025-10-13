using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblHierarchyExampleLevel
{
    public int Id { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public int? HierarchyExampleNameId { get; set; }

    public string? HierarchyExampleLevel { get; set; }

    public int? Order { get; set; }
}
