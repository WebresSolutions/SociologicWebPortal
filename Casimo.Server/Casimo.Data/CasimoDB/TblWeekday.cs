using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblWeekday
{
    public int Ref { get; set; }

    public string? FullDay { get; set; }

    public string? ShortDay { get; set; }

    public int? DisplayOrder { get; set; }
}
