using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Tier 1 of the typology - broad service groupings (class)
/// </summary>
public partial class TblInfGroup
{
    /// <summary>
    /// Unique ID for the Infrastructure Group
    /// </summary>
    public int InfGroupId { get; set; }

    /// <summary>
    /// Infrastructure Group is the highest tier of the typology. This is the broadest grouping of infrastructure types.
    /// </summary>
    public string? Group { get; set; }
}
