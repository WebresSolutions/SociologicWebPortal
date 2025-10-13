using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUserInterest
{
    /// <summary>
    /// Unique ID of the type of interest the user has in the facility
    /// </summary>
    public int UserInterestId { get; set; }

    /// <summary>
    /// The type of fiscal, ownership or other legal interest the user has in the facility
    /// </summary>
    public string? UserInterest { get; set; }

    /// <summary>
    /// Hierarchy of interests
    /// </summary>
    public int? Order { get; set; }

    public virtual ICollection<TblFacility> TblFacilities { get; set; } = new List<TblFacility>();
}
