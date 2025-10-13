using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblServiceOwner
{
    /// <summary>
    /// Unique ID for the service owner
    /// </summary>
    public int ServiceOwnerId { get; set; }

    /// <summary>
    /// LGA ID
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// Person or position within LGA with responsibility for each infrastructure type
    /// </summary>
    public string? ServiceOwner { get; set; }
}
