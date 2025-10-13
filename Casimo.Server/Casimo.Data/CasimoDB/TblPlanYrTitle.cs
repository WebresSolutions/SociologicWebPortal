using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblPlanYrTitle
{
    /// <summary>
    /// Unique name for each year that model uses (year / horizon)
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Sequential order of planning years
    /// </summary>
    public int? Order { get; set; }

    public int? DefaultYear { get; set; }

    public virtual ICollection<TblPlanYr> TblPlanYrs { get; set; } = new List<TblPlanYr>();
}
