using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblPostcode
{
    /// <summary>
    /// List of postcodes
    /// </summary>
    public short Postcode { get; set; }

    /// <summary>
    /// Spatial object (postcode boundary)
    /// </summary>
    public string? SpatialObject { get; set; }
}
