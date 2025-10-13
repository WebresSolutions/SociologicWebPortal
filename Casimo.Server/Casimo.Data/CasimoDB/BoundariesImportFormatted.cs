using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class BoundariesImportFormatted
{
    public int RecordId { get; set; }

    public string? Lgaid { get; set; }

    public string? BoundaryName { get; set; }

    public int? BoundaryTypeId { get; set; }

    public int? OldBoundaryId { get; set; }

    public string? StateCode { get; set; }

    public bool? SmallArea { get; set; }

    public bool? Suburb { get; set; }

    public bool? Municipality { get; set; }
}
