using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblLocalitiesLga
{
    public string? LocalitiesBoundaryId { get; set; }

    public string? LocalitiesBoundaryName { get; set; }

    public string? Lgaid { get; set; }

    public string? Lganame { get; set; }

    public string Id { get; set; } = null!;
}
