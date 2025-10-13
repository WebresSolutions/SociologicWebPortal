using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAltInfType
{
    /// <summary>
    /// Unique ID of relationship between InfTypeID and alternative user-defined &apos;LocalName&apos;
    /// </summary>
    public int AltInfTypeId { get; set; }

    /// <summary>
    /// InfType ID used by this database
    /// </summary>
    public int? InfTypeId { get; set; }

    /// <summary>
    /// Lookup to tblUsers
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Alternative name of the infrastructure type (defined by the user)
    /// </summary>
    public string? LocalName { get; set; }

    public virtual TblInfType? InfType { get; set; }

    public virtual TblUser? User { get; set; }
}
