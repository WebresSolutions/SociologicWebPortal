using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelServiceDataSharing
{
    public int Id { get; set; }

    public string? SharingLgaid { get; set; }

    public string? SharedWithLgaid { get; set; }
}
