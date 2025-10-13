using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilCapacityTemplatesByInfType
{
    public int Id { get; set; }

    public int? InfTypeId { get; set; }

    public int? CapacityTemplateId { get; set; }
}
