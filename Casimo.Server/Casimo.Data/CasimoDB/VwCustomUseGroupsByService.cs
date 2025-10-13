using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwCustomUseGroupsByService
{
    public int ServiceId { get; set; }

    public int? CustomUseGroupId { get; set; }

    public string? CustomUseGroupName { get; set; }
}
