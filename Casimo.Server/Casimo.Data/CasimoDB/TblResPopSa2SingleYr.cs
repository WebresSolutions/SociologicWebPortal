using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblResPopSa2SingleYr
{
    public int Id { get; set; }

    public int? OldBoundaryId { get; set; }

    public int? BoundaryId { get; set; }

    public string? Lgaid { get; set; }

    public int? Absid { get; set; }

    public string? OldSa2name { get; set; }

    public string? Sa2Name { get; set; }

    public int? Year { get; set; }

    public int? AgeGroup { get; set; }

    public string? Gender { get; set; }

    public double? Number { get; set; }
}
