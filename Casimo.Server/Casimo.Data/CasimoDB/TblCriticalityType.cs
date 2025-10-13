using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblCriticalityType
{
    /// <summary>
    /// Unique ID of the criticality type
    /// </summary>
    public int CriticalityTypeId { get; set; }

    /// <summary>
    /// Criticality levels for different types of infrastructure
    /// </summary>
    public string? CriticalityType { get; set; }

    /// <summary>
    /// Hierarchy of criticality types
    /// </summary>
    public int? Order { get; set; }

    public virtual ICollection<TblLgacriticality> TblLgacriticalities { get; set; } = new List<TblLgacriticality>();
}
