using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAssessmentList
{
    public int Id { get; set; }

    public string? ListName { get; set; }

    public string? Description { get; set; }

    public DateTime DateAdded { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<TblAssessmentListAssessment> TblAssessmentListAssessments { get; set; } = new List<TblAssessmentListAssessment>();

    public virtual ICollection<TblUserAssignedAssessmentList> TblUserAssignedAssessmentLists { get; set; } = new List<TblUserAssignedAssessmentList>();
}
