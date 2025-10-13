using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwAssetCondition
{
    public int AssetId { get; set; }

    public string? AssetRef { get; set; }

    public string? Lgaid { get; set; }

    public int? FacilityId { get; set; }

    public string? Additionalident { get; set; }

    public string? AssetRegisterName1 { get; set; }

    public string? AssetRegisterName2 { get; set; }

    public decimal? ConditionScoreOverallNumeric1 { get; set; }

    public string? ConditionDescriptionOverall1 { get; set; }

    public string? AssetNotes { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }

    public string? AssetCondition { get; set; }
}
