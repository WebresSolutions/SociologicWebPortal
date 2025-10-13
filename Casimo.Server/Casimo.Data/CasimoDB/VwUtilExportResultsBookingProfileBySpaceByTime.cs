using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class VwUtilExportResultsBookingProfileBySpaceByTime
{
    public int CasimoId { get; set; }

    public string? FacilityNameFull { get; set; }

    public string? SubSpace { get; set; }

    public string? SpaceNameFull { get; set; }

    public string? Address { get; set; }

    public string? Settlement { get; set; }

    public string? AssessedUse { get; set; }

    public string? AssessmentPeriod { get; set; }

    public DateTime? AssessmentPeriodStart { get; set; }

    public DateTime? AssessmentPeriodEnd { get; set; }

    public string? Day { get; set; }

    public string? Time { get; set; }

    public int? BookingsCount { get; set; }

    public string? Lgaid { get; set; }

    public int? DisplayOrder { get; set; }

    public int? DayRef { get; set; }
}
