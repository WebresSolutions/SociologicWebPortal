using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblLga
{
    /// <summary>
    /// Unique ID for the LGA / council based on the organisation name
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// Name of the LGA / council
    /// </summary>
    public string? Lganame { get; set; }

    /// <summary>
    /// Spatial object (polygon of LGA boundary)
    /// </summary>
    public string? SpatialObject { get; set; }

    public bool UseWorkersModule { get; set; }

    public bool? QuantityModule { get; set; }

    public bool? SuitabilityModule { get; set; }

    public bool? UtilisationModule { get; set; }

    public bool CopyDb { get; set; }

    public virtual ICollection<TblAsset> TblAssets { get; set; } = new List<TblAsset>();

    public virtual ICollection<TblUserPermission> TblUserPermissions { get; set; } = new List<TblUserPermission>();
}
