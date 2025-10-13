using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstOverallScoreStep0
{
    public int LogId { get; set; }

    public int ScoreSystemId { get; set; }

    public string Score1title { get; set; } = null!;

    public string Score2title { get; set; } = null!;

    public decimal? MinScore1 { get; set; }

    public decimal? MaxScore1 { get; set; }

    public decimal? MinScore2 { get; set; }

    public decimal? MaxScore2 { get; set; }

    public decimal? OverallScore1 { get; set; }

    public decimal? OverallScore2 { get; set; }

    public bool? Score1Applied { get; set; }

    public bool? Score2Applied { get; set; }

    public int Score1override { get; set; }

    public int Score2override { get; set; }

    public string? Explanation { get; set; }

    public string OverrideSuffix1 { get; set; } = null!;

    public string OverrideSuffix2 { get; set; } = null!;
}
