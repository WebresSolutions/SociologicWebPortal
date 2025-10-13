using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAttributeExampleAttribute
{
    public int Id { get; set; }

    public int? AttributeExampleNameId { get; set; }

    public string? AttributeExampleAttribute { get; set; }

    public int? Order { get; set; }
}
