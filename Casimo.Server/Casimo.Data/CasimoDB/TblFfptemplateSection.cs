using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfptemplateSection
{
    /// <summary>
    /// SectionID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateTitles
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// Section / category number
    /// </summary>
    public int SectionNumber { get; set; }

    /// <summary>
    /// Section / category name
    /// </summary>
    public string SectionTitle { get; set; } = null!;

    /// <summary>
    /// Is a record in tblFFPasstSectionSummaries required? i.e. is a summary comment for this section/category required?
    /// 
    /// </summary>
    public bool? SummaryRequired { get; set; }

    public bool? GenComment { get; set; }

    public bool? AssetComment { get; set; }

    /// <summary>
    /// The % weighting, where this section contributes to an overall facility score. Must be 100 or less.
    /// </summary>
    public decimal WeightPercent { get; set; }

    public bool IsLocked { get; set; }

    public int? LockedByUser { get; set; }

    public string? LockedDateTimeString { get; set; }

    /// <summary>
    /// Section / category number
    /// </summary>
    public int CommentNumber { get; set; }

    public virtual ICollection<TblFfpasstSectionResponse> TblFfpasstSectionResponses { get; set; } = new List<TblFfpasstSectionResponse>();

    public virtual ICollection<TblFfptemplateQuestion> TblFfptemplateQuestions { get; set; } = new List<TblFfptemplateQuestion>();

    public virtual TblFfptemplateTitle Template { get; set; } = null!;
}
