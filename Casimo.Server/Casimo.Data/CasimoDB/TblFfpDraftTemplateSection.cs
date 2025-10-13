using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpDraftTemplateSection
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

    /// <summary>
    /// The % weighting, where this section contributes to an overall facility score. Must be 100 or less.
    /// </summary>
    public int WeightPercent { get; set; }
}
