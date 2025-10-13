using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblInfTypeUnit
{
    /// <summary>
    /// Unique ID for the relationship between ifn types and applicable unit types
    /// </summary>
    public int InfTypeUnitId { get; set; }

    /// <summary>
    /// Unique ID of the infrastructure type to which the unit measure applies
    /// </summary>
    public int? InfTypeId { get; set; }

    /// <summary>
    /// Lookup to unit types
    /// </summary>
    public int? UnitTypeId { get; set; }

    public string? Lgaid { get; set; }

    public virtual TblInfType? InfType { get; set; }

    public virtual TblUnitType? UnitType { get; set; }
}
