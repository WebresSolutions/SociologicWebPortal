using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCustomUseGroup
{
    public int CustomUseGroupId { get; set; }

    public string? CustomUseGroupName { get; set; }

    public string? Lgaid { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }
}
