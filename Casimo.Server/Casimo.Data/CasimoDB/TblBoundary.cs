using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblBoundary
{
    /// <summary>
    /// Unique ID for the boundary
    /// </summary>
    public int BoundaryId { get; set; }

    /// <summary>
    /// ID of the municipality in which the area is located (use spatial link instead of field?)
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// Type of settlement boundary - lookup tblBoundaryTypes
    /// </summary>
    public int? BoundaryTypeId { get; set; }

    /// <summary>
    /// Unique name of boundary / area (e.g. town, suburb or locality name)
    /// </summary>
    public string? BoundaryName { get; set; }

    public string? StateCode { get; set; }

    public bool? SmallArea { get; set; }

    public bool? Suburb { get; set; }

    public bool? Municipality { get; set; }

    public bool? MeshBlock { get; set; }

    public bool? Exclude { get; set; }
}
