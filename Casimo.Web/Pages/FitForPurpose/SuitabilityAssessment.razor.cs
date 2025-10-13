using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ApiModels.Responses;
using Casimo.Shared.Constants;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Casimo.Web.Components.Dialogues;
using Casimo.Web.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;

namespace Casimo.Web.Pages.FitForPurpose;

public partial class SuitabilityAssessment : IDisposable
{

    /// <summary>
    /// Gets or sets the assessment identifier from the route parameter
    /// </summary>
    [Parameter]
    public int AssessmentId { get; set; }

    #region Private Fields

    /// <summary>
    /// The detailed assessment data loaded from the API
    /// </summary>
    private AssessmentLogDetailDto? assessment;

    /// <summary>
    /// Collection of section titles available for filtering questions
    /// </summary>
    private List<string> sections = [];

    /// <summary>
    /// Currently selected section for filtering questions
    /// </summary>
    private string? selectedSection;

    /// <summary>
    /// The count on the questions
    /// </summary>
    private int questionCount;

    /// <summary>
    /// If the save buttons are going to be visable
    /// </summary>
    private bool canViewSaveButtons = true;

    /// <summary>
    /// If the user is a temporary user
    /// </summary>
    private bool isTempUser;

    /// <summary>
    /// The question tab count 
    /// </summary>
    private int questionTabCount;

    /// <summary>
    /// The questions and response header text 
    /// </summary>
    private string questionsAndResponseHeaderText = "Questions and Responses";

    /// <summary>
    /// The assessment status as an enum 
    /// </summary>
    private AssessmentStatusEnum assessmentStatus { get; set; }

    /// <summary>
    /// A map of assessment statuses to their corresponding tab configurations
    /// </summary>
    private Dictionary<AssessmentStatusEnum, TabConfig> AssessmentTabMap = [];

    /// <summary>
    /// A time to auto-save changes periodically
    /// </summary>
    private Timer? timer;

    /// <summary>
    /// Detects if the field has changes
    /// </summary>
    private bool hasChanged = false;

    /// <summary>
    /// 
    /// </summary>
    private DateTime? lastSaved = null;

    /// <summary>
    /// The selected tab
    /// </summary>
    private int selectedTab = 0;
    #endregion

    /// <summary>
    /// Initializes the component and loads assessment data based on the AssessmentId parameter
    /// </summary>
    /// <returns>A task representing the asynchronous operation</returns>
    protected override async Task OnParametersSetAsync()
    {
        IsLoading = true;
        await LoadAssessment();
        IsLoading = false;

        // set up a timer to auto-save every 15 seconds
        timer = new(async _ => await SaveChanges(null, false), null, 15000, 15000);
    }

    /// <summary>
    /// Initializes the page
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {
        if (AuthenticationStateTask is not null)
        {
            AuthenticationState? authenticationState = await this.AuthenticationStateTask;
            isTempUser = authenticationState.User.IsInRole(RoleConstants.TemporaryUser);
        }
    }

    /// <summary>
    /// Loads an assessment from the api service
    /// </summary>
    /// <returns></returns>
    private async Task LoadAssessment()
    {

        Result<AssessmentLogDetailDto> result = await _apiService.GetAssessment(AssessmentId);
        if (result is { IsSuccess: true, Value: not null })
        {
            assessment = result.Value;
            if (sections is [] or null)
                sections = [.. result.Value.Sections
                    .Where(s => s.SectionTitle != null)
                    .Select(x => x.SectionTitle ?? "")];

            selectedSection ??= sections.FirstOrDefault();

            GetQuestionCount();

            assessmentStatus = (AssessmentStatusEnum)assessment.StatusId;
            questionsAndResponseHeaderText = assessmentStatus switch
            {
                AssessmentStatusEnum.New => "Complete the assessment below",
                AssessmentStatusEnum.InProgress => "Complete the assessment below",
                AssessmentStatusEnum.AdminReview => "Locked for review",
                AssessmentStatusEnum.Completed => "Locked for review",
                AssessmentStatusEnum.UserReview => "Review, edit and submit for completion",
                _ => "Questions and Responses"
            };
            questionTabCount = assessment.Sections.SelectMany(x => x.Questions).Count();
            canViewSaveButtons = !(isTempUser && (assessmentStatus is AssessmentStatusEnum.Completed || assessmentStatus is AssessmentStatusEnum.AdminReview));
            SetAssessmentTabMap();
            lastSaved = assessment.LastEdited;
        }
        else
        {
            _ = _snackbar.Add("Failed to load the assessment", Severity.Error);
            IsLoading = false;
            return;
        }
    }

    /// <summary>
    /// Saves changes to the assessment and updates the submission status
    /// Collects all question responses and sends them to the API
    /// </summary>
    /// <param name="submissionStatus">The new status to set for the assessment</param>
    /// <param name="showConfirmations">Whether to show confirmation dialogs</param>
    /// <returns>A task representing the asynchronous operation</returns>
    private async Task SaveChanges(AssessmentStatusEnum? submissionStatus, bool showConfirmation = true)
    {
        if (showConfirmation)
        {
            bool confirmationResult = await WebHelpers.ConfirmDialog(_dialogService, submissionStatus);
            if (!confirmationResult)
                return;
        }

        List<SaveQuestionResponseDto> questions = assessment!.Sections.SelectMany(y => y.Questions).Select(x => new SaveQuestionResponseDto
        {
            QuestionId = x.QuestionId,
            Response1 = x.ResponseText1,
            Response2 = x.ResponseText2,
            SelectionId1 = x.Selection1Id,
            SelectionId2 = x.Selection2Id
        }).ToList() ?? [];

        List<SectionSummarySaveDto> sectionSummaries =
            [.. assessment!.SectionSummaries.Select(x => new SectionSummarySaveDto(x.SectionId, x.Summary, x.FFPScore))];

        // Save other comments as section summaries
        sectionSummaries.AddRange(assessment!.GeneralComments
            .Select(x => new SectionSummarySaveDto(x.SectionId, x.Summary, x.FFPScore)));

        SaveQuestionResListDto req = new()
        {
            LogId = AssessmentId,
            QuestionList = questions,
            SubmissionType = submissionStatus,
            SectionSummaryList = sectionSummaries
        };

        Result<AssessmentLogDetailDto> result = await _apiService.SaveQuestions(req);

        if (result.IsSuccess)
        {
            assessment = result.Value;
            if (sections is [] or null)
                sections = [.. result.Value!.Sections
                    .Where(s => s.SectionTitle != null)
                    .Select(x => x.SectionTitle ?? "")];

            selectedSection ??= sections.FirstOrDefault();
        }

        if (showConfirmation)
        {
            _ = result.IsSuccess
                ? _snackbar.Add("Save question responses successful", Severity.Success)
                : _snackbar.Add("Failed to save questions", Severity.Error);
            await LoadAssessment();
        }
        // Update the last saved date and reset change tracking
        lastSaved = DateTime.UtcNow;
        StateHasChanged();
    }

    /// <summary>
    /// Opens a dialog to view users assigned to the specified assessment
    /// </summary>
    /// <param name="listId">The assessment log identifier</param>
    /// <returns>A task representing the asynchronous operation</returns>
    private Task<IDialogReference> ViewUsers(int listId)
    {
        DialogParameters<AssignedUsersDialog> parameters = new()
    {
        { x => x.ListId, listId },
        { x => x.IsLogId, true },
        { x => x.ShowAddUsers, false}
    };

        return _dialogService.ShowAsync<AssignedUsersDialog>("Assessment Users", parameters);
    }

    /// <summary>
    /// Gets the question count
    /// </summary>
    private void GetQuestionCount()
    {
        questionCount = assessment?.Sections.FirstOrDefault(x => x.SectionTitle == selectedSection)?.Questions.Count ?? 0;
    }

    /// <summary>
    /// Links to viewing a facility
    /// </summary>
    private void ViewFacility()
    {
        _navigationManager.NavigateTo($"Facilities/{assessment!.FacilityId}");
    }

    // Define a configuration record/class to hold the tab properties
    public record TabConfig(
        bool ShowResponses,
        bool ResponsesEditable,
        bool ShowGeneralCommentsTab,
        bool GeneralCommentsEditable,
        bool ShowSummariesAndScores,
        bool SummariesAndScoresEditable
    );

    private void SetAssessmentTabMap()
    {
        // Define the map for non-admin/temporary users first, as it has more variation
        Dictionary<AssessmentStatusEnum, TabConfig> nonAdminMap = new()
        {
            { AssessmentStatusEnum.New, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: true, GeneralCommentsEditable: true,
                ShowSummariesAndScores: false, SummariesAndScoresEditable: false)
            },
            { AssessmentStatusEnum.InProgress, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: true, GeneralCommentsEditable: true,
                ShowSummariesAndScores: false, SummariesAndScoresEditable: false)
            },
            { AssessmentStatusEnum.AdminReview, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: true, GeneralCommentsEditable: true,
                ShowSummariesAndScores: false, SummariesAndScoresEditable: false)
            },
            { AssessmentStatusEnum.UserReview, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: false,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            },
            { AssessmentStatusEnum.Completed, new(
                ShowResponses: true, ResponsesEditable: false,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: false,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: false)
            }
        };

        // Admin / Full user logic: always see and edit everything
        Dictionary<AssessmentStatusEnum, TabConfig> adminMap = new()
        {
            { AssessmentStatusEnum.New, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: true,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            },
            { AssessmentStatusEnum.InProgress, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: true,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            },
            { AssessmentStatusEnum.AdminReview, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: true,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            },
            { AssessmentStatusEnum.UserReview, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: true,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            },
            { AssessmentStatusEnum.Completed, new(
                ShowResponses: true, ResponsesEditable: true,
                ShowGeneralCommentsTab: false, GeneralCommentsEditable: true,
                ShowSummariesAndScores: true, SummariesAndScoresEditable: true)
            }
        };

        AssessmentTabMap = isTempUser
            ? nonAdminMap // Temporary user follows the complex business logic
            : adminMap;   // Admin / Full user sees and edits everything
    }

    private void HasChanges()
    {
        hasChanged = true;
    }

    // It is crucial to dispose of the timer to stop the background thread and prevent memory leaks.
    public void Dispose()
    {
        timer?.Dispose();
        GC.SuppressFinalize(this);
    }
}