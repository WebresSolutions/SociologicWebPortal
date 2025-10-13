using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblToolTip
{
    public int Id { get; set; }

    public string? ShortName { get; set; }

    public byte[]? Title { get; set; }

    public string? Detail { get; set; }
}
