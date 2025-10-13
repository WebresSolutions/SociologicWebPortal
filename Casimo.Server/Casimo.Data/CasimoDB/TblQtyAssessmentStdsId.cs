using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblQtyAssessmentStdsId
{
    public int Id { get; set; }

    public int QtyAssessmentStdId { get; set; }

    public int InfTypeId { get; set; }

    public int HierarchyLevelId { get; set; }

    public int Attribute1Id { get; set; }

    public int Attribute2Id { get; set; }

    public virtual TblQtyAssessmentStd QtyAssessmentStd { get; set; } = null!;
}
