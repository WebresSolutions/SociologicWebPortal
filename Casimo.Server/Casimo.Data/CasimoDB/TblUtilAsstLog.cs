using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUtilAsstLog
{
    public int Id { get; set; }

    public int FacilityId { get; set; }

    /// <summary>
    /// &apos;0&apos; if assessment is for the whole facility
    /// </summary>
    public int SubSpaceId { get; set; }

    public int InfTypeId { get; set; }

    /// <summary>
    /// Describe the nature of the usage that the assessment data is for e.g. &apos;All bookings&apos; or &apos;Sport club use&apos;
    /// </summary>
    public string? UtilisationDescription { get; set; }

    /// <summary>
    /// ID from tblUtil_CapacityTemplateTitles
    /// </summary>
    public int CapacityTemplateId { get; set; }

    public int CapacityRecordId { get; set; }

    /// <summary>
    /// ID from tblUtil_UtilTemplateTitles
    /// </summary>
    public int UtilTemplateId { get; set; }

    /// <summary>
    /// Source of the utilisation data
    /// </summary>
    public string? DataSource { get; set; }

    public DateTime? AssessmentStartDate { get; set; }

    public DateTime? AssessmentEndDate { get; set; }

    public string? AssessmentNotes { get; set; }

    public bool IsLocked { get; set; }

    public int? LockedByUser { get; set; }
}
