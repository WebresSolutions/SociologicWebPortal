using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilTimePeriodsByLga
{
    public int Id { get; set; }

    public string? Lgaid { get; set; }

    public int? UtilDayTimeStart { get; set; }

    public int? UtilDayTimeEnd { get; set; }

    public int? UtilEveningStart { get; set; }

    public int? UtilEveningEnd { get; set; }

    public bool? IsLocked { get; set; }

    public int? LockedByUser { get; set; }
}
