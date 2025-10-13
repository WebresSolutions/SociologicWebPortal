using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblServiceUnitQuantity
{
    /// <summary>
    /// Unique ID of the quantity of units for the particular service
    /// </summary>
    public int ServiceUnitQuantityId { get; set; }

    /// <summary>
    /// Lookup to tblServices
    /// </summary>
    public int? ServiceId { get; set; }

    /// <summary>
    /// Quantity of units
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Query tblInfTypeUnits where tblServices.InfTypeRef=tblInfUnitTypes.InfTypeRef and tblServices.ID=the current record
    /// </summary>
    public int? UnitTypeId { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedTime { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangedTime { get; set; }
}
