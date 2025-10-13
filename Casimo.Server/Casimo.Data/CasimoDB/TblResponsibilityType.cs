using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblResponsibilityType
{
    /// <summary>
    /// Unique ID for the type of responsibility
    /// </summary>
    public int ResponsibilityTypeId { get; set; }

    /// <summary>
    /// The responsibility that the user has for delivery of each infrastructure type
    /// </summary>
    public string? ResponsibilityType { get; set; }

    /// <summary>
    /// Hierarchy of responsibility types
    /// </summary>
    public int? Order { get; set; }
}
