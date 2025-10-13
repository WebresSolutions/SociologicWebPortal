using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstSectionScoresRangeText
{
    public int LogId { get; set; }

    public int SectionId { get; set; }

    public decimal SectionScore1 { get; set; }

    public string? SectionScore1Rating { get; set; }

    public decimal SectionScore2 { get; set; }

    public string? SectionScore2Rating { get; set; }
}
