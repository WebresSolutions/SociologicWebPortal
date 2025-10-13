using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAcecqaLga
{
    public string ServiceApprovalNumber { get; set; } = null!;

    public string? ServiceName { get; set; }

    public int LgaBoundaryId { get; set; }

    public string? Lgaid { get; set; }

    public string? Lganame { get; set; }
}
