using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfptemplateTitle
{
    /// <summary>
    /// Template ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// LGA short code from from tblLGA
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// ID from tblFFPassessmentSchemes
    /// </summary>
    public int? SchemeId { get; set; }

    /// <summary>
    /// Template title
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Extra description of template purpose
    /// </summary>
    public string? Description { get; set; }

    public virtual TblFfpassessmentScheme? Scheme { get; set; }

    public virtual ICollection<TblFfpasstLog> TblFfpasstLogs { get; set; } = new List<TblFfpasstLog>();

    public virtual ICollection<TblFfptemplateSection> TblFfptemplateSections { get; set; } = new List<TblFfptemplateSection>();
}
