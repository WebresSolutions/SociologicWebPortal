namespace Casimo.Shared.ApiModels.FitForPurpose
{
    /// <summary>
    /// Data transfer object for assessment lists
    /// Immutable record containing assessment list information and associated assessment logs
    /// </summary>
    /// <param name="Id">The unique identifier for the assessment list</param>
    /// <param name="ListName">The name of the assessment list</param>
    /// <param name="Description">The description of the assessment list</param>
    /// <param name="AssessmentLogs">The collection of assessment logs included in this list</param>
    public record class AssessmentsListDto(int Id, string ListName, string Description, bool Active, DateTime DateAdded, List<AssessmentLogPartialDto> AssessmentLogs);
}