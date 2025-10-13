using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpresultsOverallScore
{
    public string? Lgaid { get; set; }

    public int FacilityId { get; set; }

    public string? FacilitySite { get; set; }

    public double? XLongitude { get; set; }

    public double? YLatitude { get; set; }

    public string? Use { get; set; }

    public string Score1title { get; set; } = null!;

    public double? OverallScore1 { get; set; }

    public string? ScoreClassification1 { get; set; }

    public string Score2title { get; set; } = null!;

    public double? OverallScore2 { get; set; }

    public string? ScoreClassification2 { get; set; }
}
