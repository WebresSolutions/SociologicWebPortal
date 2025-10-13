using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAggregatedAreasDistinct
{
    public string? UserLgaid { get; set; }

    public string? AggrBoundaryName { get; set; }

    public int AggrBoundaryId { get; set; }

    public int? UserId { get; set; }

    public bool? IsActive { get; set; }
}
