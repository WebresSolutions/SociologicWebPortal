using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelInclForecastArea
{
    public int Id { get; set; }

    public string? ModellingLgaid { get; set; }

    public string? IncludeForecastAreaLgaid { get; set; }

    public int? IncludeForecastAreaId { get; set; }
}
