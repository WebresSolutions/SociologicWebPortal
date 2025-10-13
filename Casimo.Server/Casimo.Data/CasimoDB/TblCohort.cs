using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCohort
{
    /// <summary>
    /// Unique ID for service cohort
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Short name for service cohort
    /// </summary>
    public string? ShortName { get; set; }

    /// <summary>
    /// Lookup to tblCohortTypes
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Full description of service cohort
    /// </summary>
    public string? Description { get; set; }

    public decimal? Order { get; set; }

    public virtual ICollection<TblAgeRange> TblAgeRanges { get; set; } = new List<TblAgeRange>();
}
