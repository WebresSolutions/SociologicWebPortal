using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUserPermission
{
    /// <summary>
    /// Unique ID for the particular permissions assigned to the user
    /// </summary>
    public int PermissionId { get; set; }

    /// <summary>
    /// LGA id
    /// </summary>
    public string? Lgaid { get; set; }

    public string? PermissionToLgaid { get; set; }

    public string? PermissionType { get; set; }

    public virtual TblLga? Lga { get; set; }
}
