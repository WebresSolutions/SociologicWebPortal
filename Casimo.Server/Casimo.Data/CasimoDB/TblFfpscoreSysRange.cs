using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpscoreSysRange
{
    /// <summary>
    /// ScoreSysRangeID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPscoreSysTitles
    /// </summary>
    public int ScoreSystemId { get; set; }

    /// <summary>
    /// Questions, Sections or Overall
    /// </summary>
    public string AppliesTo { get; set; } = null!;

    /// <summary>
    /// Numeric hierarchy for ranges, where 1 = BEST POSITIVE range
    /// </summary>
    public int RangeOrder { get; set; }

    /// <summary>
    /// Lowest numeric score that range applies to; score is INCLUDED in range (&gt;=)
    /// </summary>
    public decimal ScoreLower { get; set; }

    /// <summary>
    /// Highest numeric score that range applies to; score is EXCLUDED from range (&lt;)
    /// </summary>
    public decimal ScoreUpper { get; set; }

    /// <summary>
    /// Short text value for each range (100 chars max)
    /// </summary>
    public string RangeText { get; set; } = null!;

    /// <summary>
    /// Access VBA value for conditional formatting backcolour of text box
    /// </summary>
    public int FormatColour { get; set; }
}
