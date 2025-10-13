using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblSettlementPostcode
{
    public int LocalitiesBoundaryId { get; set; }

    public string? Settlement { get; set; }

    public string? Postcode { get; set; }
}
