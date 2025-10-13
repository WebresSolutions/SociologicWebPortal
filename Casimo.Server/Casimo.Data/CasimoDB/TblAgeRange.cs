using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAgeRange
{
    public int Id { get; set; }

    public int? CohortId { get; set; }

    public int? AgeLow { get; set; }

    public int? AgeHigh { get; set; }

    public virtual TblCohort? Cohort { get; set; }
}
