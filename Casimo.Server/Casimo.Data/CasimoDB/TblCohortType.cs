using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCohortType
{
    /// <summary>
    /// Unique ID for each cohort type
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Age or other
    /// </summary>
    public string? Type { get; set; }
}
