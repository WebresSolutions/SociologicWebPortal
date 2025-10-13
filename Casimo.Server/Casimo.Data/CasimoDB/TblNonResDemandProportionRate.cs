using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblNonResDemandProportionRate
{
    public int Id { get; set; }

    /// <summary>
    /// Lookup tblInfType
    /// </summary>
    public int? InfTypeId { get; set; }

    public string? NonResType { get; set; }

    public decimal? PerResident { get; set; }

    public string? Comments { get; set; }
}
