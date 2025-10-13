using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwUtilFrmUtilTableView
{
    public int CasimoFacilityId { get; set; }

    public string? FacilityNameFull { get; set; }

    public string? SubSpace { get; set; }

    public string? SpaceNameFull { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public string? AssessedUse { get; set; }

    public string? AssessmentPeriod { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Weekday { get; set; }

    public decimal? NormalHoursUtil { get; set; }

    public decimal? CoreHoursUtil { get; set; }

    public decimal? DaytimeHoursUtil { get; set; }

    public decimal? EveningHoursUtil { get; set; }

    public string? NormalHoursUtilPercent { get; set; }

    public string? CoreHoursUtilPercent { get; set; }

    public string? DaytimeHoursUtilPercent { get; set; }

    public string? EveningHoursUtilPercent { get; set; }

    public int? UtilLogId { get; set; }

    public int? InfTypeId { get; set; }

    public int? SubSpaceId { get; set; }

    public int? DayRef { get; set; }

    public int CapacityTemplateId { get; set; }

    public int UtilTemplateId { get; set; }

    public string? Lgaid { get; set; }

    public string? CustomUseGroups { get; set; }
}
