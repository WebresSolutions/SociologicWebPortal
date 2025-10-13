using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFfpasstOverallScoreStep1
{
    public string? Lgaid { get; set; }

    public int LogId { get; set; }

    public string TemplateTitle { get; set; } = null!;

    public int ScoreSystemId { get; set; }

    public string Score1title { get; set; } = null!;

    public decimal? OverallScore1 { get; set; }

    public string? RangeText1 { get; set; }

    public int? Range1colour { get; set; }

    public string Score2title { get; set; } = null!;

    public decimal? OverallScore2 { get; set; }

    public string? RangeText2 { get; set; }

    public int? Range2colour { get; set; }

    public decimal? MinScore1 { get; set; }

    public decimal? MinScore2 { get; set; }

    public decimal? MaxScore1 { get; set; }

    public decimal? MaxScore2 { get; set; }

    public int FacilityId { get; set; }

    public string? FacilitySite { get; set; }

    public string? FacilityComponent { get; set; }

    public string? Type { get; set; }

    public int InfTypeId { get; set; }

    public int TemplateId { get; set; }
}
