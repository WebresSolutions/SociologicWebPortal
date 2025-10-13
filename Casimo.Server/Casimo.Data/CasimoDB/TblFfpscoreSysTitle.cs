using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpscoreSysTitle
{
    /// <summary>
    /// ScoreSystemID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// LGA short code from from tblLGA
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// Score system title (150 chars max)
    /// </summary>
    public string Title { get; set; } = null!;

    public decimal ModificationPercent { get; set; }
}
