using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblOwner
{
    /// <summary>
    /// Unique ID for the service owner
    /// </summary>
    public int OwnerId { get; set; }

    /// <summary>
    /// Person or position within LGA with responsibility for each infrastructure type
    /// </summary>
    public string? Owner { get; set; }

    public int? OrderCode { get; set; }
}
