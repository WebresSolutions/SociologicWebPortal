using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAssessmentStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<TblFfpasstLog> TblFfpasstLogs { get; set; } = new List<TblFfpasstLog>();
}
