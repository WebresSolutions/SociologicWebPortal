using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblOperator
{
    /// <summary>
    /// Unique ID for the service owner
    /// </summary>
    public int OperatorId { get; set; }

    /// <summary>
    /// Person or position within LGA with responsibility for each infrastructure type
    /// </summary>
    public string? Operator { get; set; }

    public int? OrderCode { get; set; }
}
