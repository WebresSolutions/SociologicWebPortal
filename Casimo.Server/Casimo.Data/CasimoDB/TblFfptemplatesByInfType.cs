using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfptemplatesByInfType
{
    public int Id { get; set; }

    /// <summary>
    /// LGA short code from from tblLGA
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// ID from tblInfType
    /// </summary>
    public int InfTypeId { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateTitle
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// Primary or Test
    /// </summary>
    public string Status { get; set; } = null!;
}
