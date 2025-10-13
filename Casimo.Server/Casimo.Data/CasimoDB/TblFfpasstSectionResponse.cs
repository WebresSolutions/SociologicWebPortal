using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpasstSectionResponse
{
    /// <summary>
    /// SummaryID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateSection
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// ID from tblFFPasstLog
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Text summary of responses to questions within the section/category
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// Numeric score #1 for section
    /// </summary>
    public decimal SectionScore1 { get; set; }

    /// <summary>
    /// Numeric score #2 for section
    /// </summary>
    public decimal SectionScore2 { get; set; }

    public virtual TblFfpasstLog Log { get; set; } = null!;

    public virtual TblFfptemplateSection Section { get; set; } = null!;
}
