using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUserAssignedAssessmentList
{
    public int AssignmentId { get; set; }

    public int UserId { get; set; }

    public int ListId { get; set; }

    public DateTime DateAssigned { get; set; }

    public virtual TblAssessmentList List { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
