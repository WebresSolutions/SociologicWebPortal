using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblSubSpace
{
    public int Id { get; set; }

    public int? FacilityId { get; set; }

    public string? SpaceName { get; set; }
}
