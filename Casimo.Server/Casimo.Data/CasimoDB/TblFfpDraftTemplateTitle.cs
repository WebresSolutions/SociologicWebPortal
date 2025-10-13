using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpDraftTemplateTitle
{
    public int Id { get; set; }

    /// <summary>
    /// LGA short code from from tblLGA
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// Template title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Extra description of template purpose
    /// </summary>
    public string? Description { get; set; }

    public DateTime? LastEdited { get; set; }

    public int? LastEditedByUserId { get; set; }

    public string? LockedBy { get; set; }

    public DateTime? LockedTime { get; set; }
}
