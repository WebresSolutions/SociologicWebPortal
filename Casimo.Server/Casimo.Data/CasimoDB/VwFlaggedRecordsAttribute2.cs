using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwFlaggedRecordsAttribute2
{
    public int? FacilityId { get; set; }

    public int ServiceId { get; set; }

    public int? AttributeName2Id { get; set; }

    public int Attribute2Id { get; set; }

    public string? Type { get; set; }
}
