using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUserAssessmentLog
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int LogId { get; set; }

    public DateTime DateAssigned { get; set; }

    public virtual TblFfpasstLog Log { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
