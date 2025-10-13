using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Tier 3 of the typology - specific and unique names for each infrastructure type. Provision standards are based on infrastructure types.
/// </summary>
public partial class TblInfType
{
    /// <summary>
    /// Unique ID for each Infrastructure Class
    /// </summary>
    public int InfTypeId { get; set; }

    /// <summary>
    /// Related Infrastructure Class ID from tblInfClass
    /// </summary>
    public int? InfClassId { get; set; }

    /// <summary>
    /// Infrastructure Type is the third and finest tier of the typology and is the specific unique name assigned to distinct types of infrastructure.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Description of the Use
    /// </summary>
    public string? Definition { get; set; }

    public int? DefaultCohortId { get; set; }

    public int? DefaultUnitTypeId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public string? Lgaid { get; set; }

    public virtual ICollection<TblAltInfType> TblAltInfTypes { get; set; } = new List<TblAltInfType>();

    public virtual ICollection<TblInfTypeUnit> TblInfTypeUnits { get; set; } = new List<TblInfTypeUnit>();

    public virtual ICollection<TblService> TblServices { get; set; } = new List<TblService>();
}
