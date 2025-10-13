using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblKinderLdcmodelServiceDatum
{
    public int Id { get; set; }

    public int FacilityId { get; set; }

    public string ServiceType { get; set; } = null!;

    public string? AcecqaserviceApprovalId { get; set; }

    public string FundedService { get; set; } = null!;

    public int KcaServiceTotalLps { get; set; }

    public int LgaagreedServiceTotalLps { get; set; }

    public string? RoomNumberAndLps { get; set; }

    public bool? Kinder3yoenrolments2023Unknown { get; set; }

    public bool? Kinder3yoenrolments2024Unknown { get; set; }

    public bool? Kinder3yoenrolments2025Unknown { get; set; }

    public int? Kinder3yoenrolments2023 { get; set; }

    public int? Kinder3yoenrolments2024 { get; set; }

    public int? Kinder3yoenrolments2025 { get; set; }

    public decimal? Kinder3yoavgHours2023 { get; set; }

    public decimal? Kinder3yoavgHours2024 { get; set; }

    public decimal? Kinder3yoavgHours2025 { get; set; }

    public bool? Kinder4yoenrolments2023Unknown { get; set; }

    public bool? Kinder4yoenrolments2024Unknown { get; set; }

    public bool? Kinder4yoenrolments2025Unknown { get; set; }

    public int? Kinder4yoenrolments2023 { get; set; }

    public int? Kinder4yoenrolments2024 { get; set; }

    public int? Kinder4yoenrolments2025 { get; set; }

    public string? Notes { get; set; }

    public byte[]? Sqltimestamp { get; set; }
}
