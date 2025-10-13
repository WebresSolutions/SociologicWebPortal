using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblQtyAssessmentStd
{
    public int QtyAssessmentStdId { get; set; }

    public string? StdName { get; set; }

    public string? Lgaid { get; set; }

    public int? UnitTypeId { get; set; }

    public decimal? TargetUnits { get; set; }

    public decimal? TargetPop { get; set; }

    public decimal? TriggerPop { get; set; }

    public string? Rationale { get; set; }

    /// <summary>
    /// ID of the cohort preferred by user
    /// </summary>
    public int? PreferredCohortId { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public virtual ICollection<TblQtyAssessmentStdsId> TblQtyAssessmentStdsIds { get; set; } = new List<TblQtyAssessmentStdsId>();
}
