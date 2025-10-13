namespace Casimo.Shared.ApiModels.FitForPurpose;

/// <summary>
/// Data transfer object for the home page list of fitness for purpose assessments
/// Contains summary information for displaying assessment overviews
/// </summary>
public class FitForPurposeHomeListDto
{
    /// <summary>
    /// Gets or sets the CASIMO Facility full name
    /// This will be a concatenation of tblFacilities.Site and tblFacilities.Component which is a field I can create in whichever table we read from, or create as a query to concatenate it for use on the form.
    /// </summary>
    public string FacilityName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the relevant use name from tblInfType
    /// Linked from tblFFPasstLog.InfTypeID to tblInfType.InfTypeID
    /// </summary>
    public string AssessmentUseCase { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last edited date of the assessment
    /// </summary>
    public DateTime? LastEdited { get; set; }

    /// <summary>
    /// Gets or sets the name of the user which last edited the assessment
    /// </summary>
    public string LastEditedBy { get; set; } = string.Empty;
}