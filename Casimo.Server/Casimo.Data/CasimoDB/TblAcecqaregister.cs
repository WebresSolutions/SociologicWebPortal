using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblAcecqaregister
{
    public string ServiceApprovalNumber { get; set; } = null!;

    public string? ProviderApprovalNumber { get; set; }

    public string? ServiceName { get; set; }

    public string? ProviderName { get; set; }

    public string? ServiceType { get; set; }

    public string? ServiceAddress { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public int? Postcode { get; set; }

    public double? XLongitude { get; set; }

    public double? YLatitude { get; set; }

    public string? Lgaid { get; set; }

    public string? LgaNameShort { get; set; }

    public string? LgaNameAbs { get; set; }

    public int? ApprovedPlaces { get; set; }

    public string? LongDayCare { get; set; }

    public string? PreschoolPartOfSchool { get; set; }

    public string? PreschoolStandAlone { get; set; }

    public string? AnyPreschool { get; set; }

    public string? AnyPreschoolOrLdc { get; set; }

    public string? AfterSchoolCare { get; set; }

    public string? BeforeSchoolCare { get; set; }

    public string? VacationCare { get; set; }
}
