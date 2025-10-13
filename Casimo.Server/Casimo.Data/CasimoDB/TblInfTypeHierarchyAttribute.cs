using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblInfTypeHierarchyAttribute
{
    public int InfTypeId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public string Lgaid { get; set; } = null!;

    public int? HierarchyNameId { get; set; }

    public int? AttributeName1Id { get; set; }

    public int? AttributeName2Id { get; set; }
}
