using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUnitType
{
    /// <summary>
    /// Unique ID for the unit type
    /// </summary>
    public int UnitTypeId { get; set; }

    /// <summary>
    /// Different units that quantity of provision may be measured in
    /// </summary>
    public string? UnitType { get; set; }

    public string? Singular { get; set; }

    public string? Definition { get; set; }

    public int? Rounding { get; set; }

    public virtual ICollection<TblInfTypeUnit> TblInfTypeUnits { get; set; } = new List<TblInfTypeUnit>();
}
