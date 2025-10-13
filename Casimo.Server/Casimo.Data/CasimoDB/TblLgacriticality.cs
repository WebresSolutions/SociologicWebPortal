using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblLgacriticality
{
    public int LgacriticalityId { get; set; }

    public string? Lgaid { get; set; }

    public int? InfTypeId { get; set; }

    public int? CriticalityTypeId { get; set; }

    public virtual TblCriticalityType? CriticalityType { get; set; }
}
