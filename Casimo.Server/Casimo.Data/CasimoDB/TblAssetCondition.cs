using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAssetCondition
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public string? AssetRefPrimary { get; set; }

    public string? AssetRefSecondary { get; set; }

    public string? AssetOwner { get; set; }

    public string? AssetHierarchyPrimary { get; set; }

    public string? AssetHierarchySecondary { get; set; }

    public string? AssetNamePrimary { get; set; }

    public string? AltAssetName1 { get; set; }

    public string? AssetClassPrimary { get; set; }

    public string? AssetClassSecondry { get; set; }

    public string? AssetTypePrimary { get; set; }

    public string? AssetTypeSecondary { get; set; }

    public decimal? AssetConditionScoreOverallNumeric1 { get; set; }

    public string? AssetConditionScoringDescription { get; set; }

    public string? AssetConditionOverallDescription1 { get; set; }

    public string? AssetLocationFromRegister1 { get; set; }

    public string? AssetLocationFromRegister2 { get; set; }

    public string? AssetLocationFromRegister3 { get; set; }

    public string? AssetLocationFromRegister4 { get; set; }

    public string? AssetNotes { get; set; }
}
