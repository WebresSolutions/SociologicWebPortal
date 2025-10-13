using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Tier 2 of the typology - infrastructure classes that may require further definition as infrastructure types
/// </summary>
public partial class TblInfClass
{
    /// <summary>
    /// Unique ID for each infrastructure class
    /// </summary>
    public int InfClassId { get; set; }

    /// <summary>
    /// Related Infrastructure Group ID from tblInfGroup
    /// </summary>
    public int? InfGroupId { get; set; }

    /// <summary>
    /// Infrastructure Class is the second tier of the typology and is the first breakdown of infrastructure under the Infrastructure Group
    /// </summary>
    public string? Class { get; set; }
}
