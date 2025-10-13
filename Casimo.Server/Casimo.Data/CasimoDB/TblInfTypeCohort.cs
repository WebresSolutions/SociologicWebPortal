using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblInfTypeCohort
{
    public int Id { get; set; }

    /// <summary>
    /// Lookup tblInfType
    /// </summary>
    public int? InfTypeId { get; set; }

    /// <summary>
    /// User ID
    /// </summary>
    public string? UserLgaid { get; set; }

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

    public byte[]? Ts { get; set; }
}
