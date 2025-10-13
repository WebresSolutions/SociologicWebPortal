using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelInclFacility
{
    public int Id { get; set; }

    public string? ModellingLgaid { get; set; }

    public int? FacilityId { get; set; }

    public string? FacilityLgaid { get; set; }
}
