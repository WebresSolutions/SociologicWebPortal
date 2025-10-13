using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilResultsPcbyDay
{
    public int Id { get; set; }

    public string? Lgaid { get; set; }

    public int? UtilLogId { get; set; }

    public int? SubSpaceId { get; set; }

    public int? FacilityId { get; set; }

    public int? InfTypeId { get; set; }

    public string? DayName { get; set; }

    public int? DayRef { get; set; }

    public decimal? UtilPc { get; set; }

    public decimal? UtilPcCore { get; set; }

    public decimal? UtilPcDaytime { get; set; }

    public decimal? UtilPcEvening { get; set; }
}
