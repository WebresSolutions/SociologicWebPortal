using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelGlobalAssumptionsDelete
{
    public int Id { get; set; }

    public string ModellingLgaid { get; set; } = null!;

    public decimal? GlobalCapacityMultiplierPreschoolStdMgmt { get; set; }

    public decimal? GlobalAdjustmentRatePreschoolStdMgmt { get; set; }

    public decimal? GlobalCapacityMultiplierPreschoolChangeMgmt { get; set; }

    public decimal? GlobalAdjustmentRatePreschoolChangeMgmt { get; set; }

    public decimal? GlobalCapacityMultiplierLdc { get; set; }

    public decimal? GlobalAdjustmentRateLdc { get; set; }

    public int? GlobalEnrolmentDataYear { get; set; }
}
