using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstOverallScoreBaseQQn
{
    public int LogId { get; set; }

    public int ScoreSystemId { get; set; }

    public string Score1title { get; set; } = null!;

    public string Score2title { get; set; } = null!;

    public int? Qscore1 { get; set; }

    public int? Qscore2 { get; set; }

    public bool? OverrideScore1Applied { get; set; }

    public bool? OverrideScore2Applied { get; set; }

    public int OverrideScore1 { get; set; }

    public int OverrideScore2 { get; set; }

    public decimal WeightPercent { get; set; }
}
