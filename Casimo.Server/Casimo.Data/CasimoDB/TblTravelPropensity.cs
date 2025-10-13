using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblTravelPropensity
{
    public int Id { get; set; }

    /// <summary>
    /// LGAid of modelling LGA
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// InfTypeID of the Use that this propensity is for
    /// </summary>
    public int? UseId { get; set; }

    /// <summary>
    /// Boundary ID of source area
    /// </summary>
    public int? BoundaryIdFrom { get; set; }

    /// <summary>
    /// Boundary ID of destination area
    /// </summary>
    public int? BoundaryIdTo { get; set; }

    /// <summary>
    /// 1=100% propensity to travel from &apos;FROM&apos; to &apos;TO&apos;, 0=0%
    /// </summary>
    public decimal? PropensityDecimal { get; set; }
}
