using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilTimeCode
{
    /// <summary>
    /// Unique code for each 30 minute time slot
    /// </summary>
    public double SlotCode { get; set; }

    /// <summary>
    /// Start time of the time slot as shown in a Date/Time (Short Time) formatted field
    /// </summary>
    public DateTime? StartTimeDt { get; set; }

    /// <summary>
    /// End time of the time slot as shown in a Date/Time (Short Time) formatted field
    /// </summary>
    public DateTime? EndTimeDt { get; set; }

    public DateTime? Lgaequivalent { get; set; }

    /// <summary>
    /// string equivalent of start time
    /// </summary>
    public string? StartTimeStr { get; set; }

    /// <summary>
    /// string equivalent of end time
    /// </summary>
    public string? EndTimeStr { get; set; }

    public string? StartTimeStrAmpm { get; set; }

    public string? EndTimeStrAmpm { get; set; }
}
