using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwUtilExportBookingDataBySpace
{
    public string? Lgaid { get; set; }

    public int FacilityId { get; set; }

    public string? FacilitySite { get; set; }

    public string? FacilityComponent { get; set; }

    public string? SpaceName { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public short? Postcode { get; set; }

    public string? LgabookingRef { get; set; }

    public string? BookingDate { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? BookingCategory { get; set; }

    public string? HirerCategory { get; set; }

    public string? HirerRef { get; set; }

    public string? BookingDescription { get; set; }
}
