using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblPermissionType
{
    /// <summary>
    /// Unique ID for each permission type
    /// </summary>
    public int PermissionTypeId { get; set; }

    /// <summary>
    /// Read or Write
    /// </summary>
    public string? PermissionType { get; set; }
}
