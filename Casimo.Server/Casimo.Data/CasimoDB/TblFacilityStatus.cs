using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFacilityStatus
{
    /// <summary>
    /// Unique ID of facility statuses
    /// </summary>
    public int FacilityStatusId { get; set; }

    public string? FacilityStatus { get; set; }

    public int? OrderCode { get; set; }

    public virtual ICollection<TblFacility> TblFacilities { get; set; } = new List<TblFacility>();
}
