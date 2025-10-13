using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwUtilExportAvailableTargetHoursBySpace
{
    public string? Lgaid { get; set; }

    public int FacilityId { get; set; }

    public string? FacilitySite { get; set; }

    public string? FacilityComponent { get; set; }

    public string? SpaceName { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public decimal? MonTotalHours { get; set; }

    public decimal? TueTotalHours { get; set; }

    public decimal? WedTotalHours { get; set; }

    public decimal? ThuTotalHours { get; set; }

    public decimal? FriTotalHours { get; set; }

    public decimal? SatTotalHours { get; set; }

    public decimal? SunTotalHours { get; set; }
}
