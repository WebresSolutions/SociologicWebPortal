using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblPlanYr
{
    public int Id { get; set; }

    /// <summary>
    /// LGA id
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// Lookup to tblPlanYrTitles
    /// </summary>
    public string? YearTitle { get; set; }

    /// <summary>
    /// Actual year of each model horizon
    /// </summary>
    public int? ActualYear { get; set; }

    public virtual TblPlanYrTitle? YearTitleNavigation { get; set; }
}
