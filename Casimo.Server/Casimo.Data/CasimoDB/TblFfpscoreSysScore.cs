using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpscoreSysScore
{
    /// <summary>
    /// ScoreSysScoreID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblScoreSysTitles
    /// </summary>
    public int ScoreSysTitleId { get; set; }

    /// <summary>
    /// Questions, Sections or Overall
    /// </summary>
    public string AppliesTo { get; set; } = null!;

    /// <summary>
    /// Number, Percent or Text
    /// </summary>
    public string DisplayAs { get; set; } = null!;

    /// <summary>
    /// Numeric order in which scores appear in list, where 1 = highest or BEST POSITIVE score.
    /// </summary>
    public int ScoreOrder { get; set; }

    /// <summary>
    /// Numeric (or percentage?) score
    /// </summary>
    public decimal Score { get; set; }

    /// <summary>
    /// Where .DisplayAs = Number, shown = number. Where .DisplayAs = Percent, shown = number &amp; &quot;%&quot;. Where .DisplayAs = Text, shown = entered text value
    /// </summary>
    public string? ShownValue { get; set; }

    /// <summary>
    /// Additional explanation or definiton of score / text value meaning (150 chars max)
    /// </summary>
    public string? Description { get; set; }
}
