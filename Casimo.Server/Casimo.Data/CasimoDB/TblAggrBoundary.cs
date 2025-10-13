using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAggrBoundary
{
    /// <summary>
    /// Unique ID of relationship between aggregated and component boundaries
    /// </summary>
    public int AggrBoundaryId { get; set; }

    /// <summary>
    /// ID of the user who has defined these aggrgated areas
    /// </summary>
    public string? UserLgaid { get; set; }

    /// <summary>
    /// Name of the aggregated boundary
    /// </summary>
    public string? AggrBoundaryName { get; set; }

    public int? CommonYearFrom { get; set; }

    public int? CommonYearTo { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public int? UserId { get; set; }
}
