using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAttribute
{
    public int AttributeId { get; set; }

    /// <summary>
    /// 4 digit LGAid for the municipality in which the facility is located
    /// </summary>
    public int? AttributeNameId { get; set; }

    public string? Attribute { get; set; }

    public int? Order { get; set; }

    public virtual TblAttributeName? AttributeName { get; set; }
}
