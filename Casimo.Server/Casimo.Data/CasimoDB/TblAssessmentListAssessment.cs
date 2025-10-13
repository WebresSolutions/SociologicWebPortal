using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAssessmentListAssessment
{
    public int ListId { get; set; }

    public int LogId { get; set; }

    public DateTime DateAdded { get; set; }

    public virtual TblAssessmentList List { get; set; } = null!;

    public virtual TblFfpasstLog Log { get; set; } = null!;
}
