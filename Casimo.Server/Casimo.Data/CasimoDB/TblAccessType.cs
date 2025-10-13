using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

/// <summary>
/// Level of access to the facility by the general public
/// </summary>
public partial class TblAccessType
{
    /// <summary>
    /// Unique ID of the type of public access to each service
    /// </summary>
    public int AccessTypeId { get; set; }

    /// <summary>
    /// Public (free or paid access by general public), Limited (certain public), Private
    /// </summary>
    public string? AccessType { get; set; }

    /// <summary>
    /// Rank order for sorting and prioritisation purposes (&apos;Public&apos; = highest rank)
    /// </summary>
    public int? Order { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TblService> TblServices { get; set; } = new List<TblService>();
}
