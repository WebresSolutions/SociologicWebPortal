using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblHierarchyName
{
    public int HierarchyNameId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public string? Lgaid { get; set; }

    public string? HierarchyName { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public virtual ICollection<TblHierarchyLevel> TblHierarchyLevels { get; set; } = new List<TblHierarchyLevel>();
}
