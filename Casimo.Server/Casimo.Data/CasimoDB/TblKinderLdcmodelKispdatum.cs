using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelKispdatum
{
    public int Id { get; set; }

    public int? OldSa2areaId { get; set; }

    public string? ModellingLgaid { get; set; }

    public int? Sa2areaId { get; set; }

    public string? DataTitle { get; set; }

    public string? DataType { get; set; }

    public int? Year { get; set; }

    public int? Value { get; set; }
}
