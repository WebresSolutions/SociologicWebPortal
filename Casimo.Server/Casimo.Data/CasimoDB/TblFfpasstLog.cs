using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpasstLog
{
    /// <summary>
    /// LogID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFacilities
    /// </summary>
    public int FacilityId { get; set; }

    /// <summary>
    /// ID from tblInfType
    /// </summary>
    public int InfTypeId { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateTitles
    /// </summary>
    public int TemplateId { get; set; }

    /// <summary>
    /// Date the assessment was completed or last updated
    /// </summary>
    public DateTime AssessmentDate { get; set; }

    /// <summary>
    /// Name(s) of assessor and/or respondees
    /// </summary>
    public string? AssessmentPersons { get; set; }

    /// <summary>
    /// Additional comments on the assessment
    /// </summary>
    public string? AssessmentNotes { get; set; }

    public int StatusId { get; set; }

    public DateTime? LastEdited { get; set; }

    public string? LastEditedBy { get; set; }

    public virtual TblAssessmentStatus Status { get; set; } = null!;

    public virtual ICollection<TblAssessmentListAssessment> TblAssessmentListAssessments { get; set; } = new List<TblAssessmentListAssessment>();

    public virtual ICollection<TblFfpasstQuestionResponse> TblFfpasstQuestionResponses { get; set; } = new List<TblFfpasstQuestionResponse>();

    public virtual ICollection<TblFfpasstSectionResponse> TblFfpasstSectionResponses { get; set; } = new List<TblFfpasstSectionResponse>();

    public virtual TblFfptemplateTitle Template { get; set; } = null!;
}
