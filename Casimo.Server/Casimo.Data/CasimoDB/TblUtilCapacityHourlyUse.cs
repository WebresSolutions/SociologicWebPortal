using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilCapacityHourlyUse
{
    public int Id { get; set; }

    public int? OldUseSpaceId { get; set; }

    /// <summary>
    /// ID from tblFacilities
    /// </summary>
    public int? FacilityId { get; set; }

    public int? InfTypeId { get; set; }

    /// <summary>
    /// ID fromtblSubSpaces
    /// </summary>
    public int? SubSpaceId { get; set; }

    public bool? UseCoreHours { get; set; }

    /// <summary>
    /// Optional: user may define multiple seasons
    /// </summary>
    public int? SeasonNumber { get; set; }

    /// <summary>
    /// Optional name for each season
    /// </summary>
    public string? SeasonName { get; set; }

    /// <summary>
    /// Start month for each season, where 1 = January
    /// </summary>
    public int? SeasonStart { get; set; }

    /// <summary>
    /// End month for each season, where 1 = January
    /// </summary>
    public int? SeasonEnd { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? MonBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? MonStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? MonEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? TueBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? TueStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? TueEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? WedBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? WedStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? WedEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? ThuBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? ThuStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? ThuEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? FriBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? FriStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? FriEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? SatBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? SatStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? SatEndTime { get; set; }

    /// <summary>
    /// Facility is bookable on this day of the week
    /// </summary>
    public bool? SunBookable { get; set; }

    /// <summary>
    /// Earliest time facility can be booked from
    /// </summary>
    public double? SunStartTime { get; set; }

    /// <summary>
    /// Latest time facility can be booked until
    /// </summary>
    public double? SunEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? MonCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? MonCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? TueCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? TueCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? WedCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? WedCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? ThuCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? ThuCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? FriCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? FriCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? SatCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? SatCoreEndTime { get; set; }

    /// <summary>
    /// Start of core / peak hours
    /// </summary>
    public int? SunCoreStartTime { get; set; }

    /// <summary>
    /// End of core / peak hours
    /// </summary>
    public int? SunCoreEndTime { get; set; }

    public decimal? MonTotalHours { get; set; }

    public decimal? TueTotalHours { get; set; }

    public decimal? WedTotalHours { get; set; }

    public decimal? ThuTotalHours { get; set; }

    public decimal? FriTotalHours { get; set; }

    public decimal? SatTotalHours { get; set; }

    public decimal? SunTotalHours { get; set; }

    public decimal? WeekTotalHours { get; set; }

    public decimal? MonthTotalHours { get; set; }

    public decimal? YearTotalHours { get; set; }

    public decimal? SimpleMaxCapacity { get; set; }

    public bool IsLocked { get; set; }

    public int? LockedByUser { get; set; }
}
