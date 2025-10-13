using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelDefaultVariable
{
    public int Id { get; set; }

    public string? VarTypes { get; set; }

    public string? VarDescription { get; set; }

    public string? DefaultValue { get; set; }

    public bool? YearVariable { get; set; }

    public bool? FacilityVariable { get; set; }
}
