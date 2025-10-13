using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstOverallScoreSubQQnAvg
{
    public int LogId { get; set; }

    public int ScoreSystemId { get; set; }

    public string Score1title { get; set; } = null!;

    public string Score2title { get; set; } = null!;

    public int? MinScore1 { get; set; }

    public int? MinScore2 { get; set; }

    public int? MaxScore1 { get; set; }

    public int? MaxScore2 { get; set; }

    public bool? OverrideScore1Applied { get; set; }

    public bool? OverrideScore2Applied { get; set; }

    public int OverrideScore1 { get; set; }

    public int OverrideScore2 { get; set; }

    public decimal? OverallScore1 { get; set; }

    public decimal? OverallScore2 { get; set; }
}
