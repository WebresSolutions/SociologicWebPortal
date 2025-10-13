using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilHourlyBookingDatum
{
    /// <summary>
    /// CASIMO unique booking reference
    /// </summary>
    public int Id { get; set; }

    public int OldUseSpaceId { get; set; }

    /// <summary>
    /// ID from tblSubSpaces
    /// </summary>
    public int? SubSpaceId { get; set; }

    /// <summary>
    /// ID from tblFacilities
    /// </summary>
    public int? FacilityId { get; set; }

    public int? InfTypeId { get; set; }

    public bool? Include { get; set; }

    /// <summary>
    /// LGA&apos;s unique reference for booking
    /// </summary>
    public string? LgabookingRef { get; set; }

    public int? DurationFormat { get; set; }

    /// <summary>
    /// Short date of booking
    /// </summary>
    public DateTime? BookingDate { get; set; }

    /// <summary>
    /// Short time start
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Short time end
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// LGA category for the type of ACTIVITY (e.g. community meeting)
    /// </summary>
    public string? BookingCategory { get; set; }

    /// <summary>
    /// LGA category for the type of HIRER (e.g. community group)
    /// </summary>
    public string? HirerCategory { get; set; }

    /// <summary>
    /// LGA unique reference for hirer
    /// </summary>
    public string? HirerRef { get; set; }

    /// <summary>
    /// LGA detailed description of BOOKING (e.g. Historical Society)
    /// </summary>
    public string? BookingDescription { get; set; }

    /// <summary>
    /// Original start time rounded to nearest half hour
    /// </summary>
    public DateTime? StartTimeRounded { get; set; }

    /// <summary>
    /// Original end time rounded to nearest half hour
    /// </summary>
    public DateTime? EndTimeRounded { get; set; }

    /// <summary>
    /// CASIMO time slot code equivalent for start time, rounded to nearest half hour
    /// </summary>
    public int? StartTimeCode { get; set; }

    /// <summary>
    /// CASIMO time slot code equivalent for end time, rounded to nearest half hour
    /// </summary>
    public int? EndTimeCode { get; set; }

    /// <summary>
    /// Duration of booking. Decimal expression of whole and half hours (e.g. 1.5 hours)
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// Day of the week
    /// </summary>
    public string? ShortDayName { get; set; }

    /// <summary>
    /// 1=Sunday, 2=Monday etc
    /// </summary>
    public int? DayRef { get; set; }
}
