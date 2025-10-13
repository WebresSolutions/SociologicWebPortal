using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblTypologyLog
{
    public int Id { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public string? Lgaid { get; set; }

    public int? UserId { get; set; }

    public DateTime? Date { get; set; }

    public string? Reason { get; set; }

    public int? QtyAssessmentStdId { get; set; }

    public int? InfTypeId { get; set; }

    public int? HierarchyNameId { get; set; }

    public int? AttributeName1Id { get; set; }

    public int? AttributeName2Id { get; set; }

    public bool? Actioned { get; set; }
}
