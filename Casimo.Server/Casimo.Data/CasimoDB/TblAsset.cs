using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAsset
{
    /// <summary>
    /// Unique ID for each asset
    /// </summary>
    public int AssetId { get; set; }

    /// <summary>
    /// Asset reference used by the LGA (not unique to table)
    /// </summary>
    public string? AssetRef { get; set; }

    /// <summary>
    /// ID of the LGA in which the asset is located
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// ID of the facility related to the asset
    /// </summary>
    public int? FacilityId { get; set; }

    /// <summary>
    /// Name of the LGA asset register (e.g. Buildings, Playspaces) on which the asset is recorded
    /// </summary>
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

    public virtual TblFacility? Facility { get; set; }

    public virtual TblLga? Lga { get; set; }
}
