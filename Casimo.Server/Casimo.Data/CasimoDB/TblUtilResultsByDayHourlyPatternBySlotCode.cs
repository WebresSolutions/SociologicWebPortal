using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilResultsByDayHourlyPatternBySlotCode
{
    public int Id { get; set; }

    public string? Lgaid { get; set; }

    public int? UtilLogId { get; set; }

    public int? CapacityRecordId { get; set; }

    public int? FacilityId { get; set; }

    public int? SubSpaceId { get; set; }

    public int? InfTypeId { get; set; }

    public int? DayRef { get; set; }

    public int? SlotCode { get; set; }

    public int? CountSlotCode { get; set; }
}
