using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TbltmpSa2copyKisp
{
    public int BoundaryId { get; set; }

    public string? Lgaid { get; set; }

    public int? BoundaryTypeId { get; set; }

    public string? BoundaryName { get; set; }

    public string? StateCode { get; set; }

    public bool? SmallArea { get; set; }

    public bool? Suburb { get; set; }

    public bool? Municipality { get; set; }

    public bool? MeshBlock { get; set; }

    public bool? Exclude { get; set; }
}
