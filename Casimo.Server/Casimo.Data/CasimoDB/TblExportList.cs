using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblExportList
{
    public string? CurrentMode { get; set; }

    public string? ExportItem { get; set; }

    public int Id { get; set; }

    public string? ExportQuery { get; set; }

    public string? ExportFilters { get; set; }

    public string? ExportTypes { get; set; }

    public bool? ExportMnec { get; set; }
}
