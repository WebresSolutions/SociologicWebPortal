using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstOverallScoreSecWtAvgStep0
{
    public int LogId { get; set; }

    public int ScoreSystemId { get; set; }

    public string Score1title { get; set; } = null!;

    public string Score2title { get; set; } = null!;

    public decimal? UnroundedOverallScore1 { get; set; }

    public decimal? UnroundedOverallScore2 { get; set; }

    public decimal? MinSectionScore1 { get; set; }

    public decimal? MinSectionScore2 { get; set; }
}
