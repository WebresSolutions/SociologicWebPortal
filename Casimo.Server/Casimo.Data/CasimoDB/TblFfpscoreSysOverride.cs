using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpscoreSysOverride
{
    /// <summary>
    /// OverrideID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFacilities
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Yes, where override is applied. No, only where an override has been applied previously but has since been de-applied
    /// </summary>
    public bool? Score1Applied { get; set; }

    public bool? Score2Applied { get; set; }

    /// <summary>
    /// Score1 or Score2 (if in use) e.g. FFP now and FFP future (optional)
    /// </summary>
    public int Score1override { get; set; }

    /// <summary>
    /// Numeric score to override calculated overall score
    /// </summary>
    public int Score2override { get; set; }

    /// <summary>
    /// Long text explanation of the rationale for applying the override
    /// </summary>
    public string? Explanation { get; set; }
}
