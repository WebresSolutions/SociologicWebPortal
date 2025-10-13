using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblLgaresponsibility
{
    public int LgaresponsibilityId { get; set; }

    public string? Lgaid { get; set; }

    public int? InfTypeId { get; set; }

    /// <summary>
    /// Service delivery role or the LGA for each inf type
    /// </summary>
    public int? ResponsibilityTypeId { get; set; }
}
