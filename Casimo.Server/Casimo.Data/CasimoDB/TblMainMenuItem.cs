using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblMainMenuItem
{
    public int Id { get; set; }

    /// <summary>
    /// Use format &apos;Menu01&apos;
    /// </summary>
    public string? MenuNumber { get; set; }

    /// <summary>
    /// Max 100 ch
    /// </summary>
    public string? MenuItem { get; set; }

    public int? MenuOrder { get; set; }
}
