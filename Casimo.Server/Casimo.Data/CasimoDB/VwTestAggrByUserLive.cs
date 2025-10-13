using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwTestAggrByUserLive
{
    public string? UserLgaid { get; set; }

    public int? UserId { get; set; }

    public int AggrBoundaryId { get; set; }

    public string? AggrBoundaryName { get; set; }

    public double? Year { get; set; }

    public double? Population { get; set; }

    public string? Cohort { get; set; }
}
