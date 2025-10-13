using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFacilityDateLastUpdatedBaseQ
{
    public int FacilityId { get; set; }

    public DateTime? AddedTimeFacility { get; set; }

    public DateTime? ChangedTimeFacility { get; set; }

    public DateTime? AddedTimeService { get; set; }

    public DateTime? ChangedTimeService { get; set; }

    public DateTime? AddedTimeServiceQty { get; set; }

    public DateTime? ChangedTimeServiceQty { get; set; }
}
