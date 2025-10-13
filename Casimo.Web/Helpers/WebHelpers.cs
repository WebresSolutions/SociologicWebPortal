using Casimo.Shared.Constants;
using Casimo.Shared.Enums;
using MudBlazor;

namespace Casimo.Web.Helpers;

/// <summary>
/// Utility class for mapping user roles to MudBlazor color schemes
/// Provides consistent color coding for different user roles in the UI
/// </summary>
public static class WebHelpers
{
    private static readonly Dictionary<AssessmentStatusEnum, string> AssessmentStatusColors = new()
    {
        { AssessmentStatusEnum.New, "#64748b" },              // Neutral gray
        { AssessmentStatusEnum.InProgress, "#3b82f6" },       // Blue
        { AssessmentStatusEnum.AdminReview, "#f59e0b" },      // Amber/Orange
        { AssessmentStatusEnum.UserReview, "#ef4444" },       // Red
        { AssessmentStatusEnum.Completed, "#10b981" }         // Green
    };

    /// <summary>
    /// Maps a role name to its corresponding MudBlazor color for consistent UI theming
    /// </summary>
    /// <param name="roleName">The name of the role to get a color for</param>
    /// <returns>A MudBlazor Color value appropriate for the specified role</returns>
    public static Color ColourHelper(string roleName)
    {
        return roleName switch
        {
            RoleConstants.AdminUser => Color.Primary,
            RoleConstants.FullUser => Color.Secondary,
            RoleConstants.TemporaryUser => Color.Info,
            _ => Color.Secondary
        };
    }

    /// <summary>
    /// Maps an assessment status enum to its corresponding color code for UI display
    /// </summary>
    /// <param name="status">The assessment status to get a color for</param>
    /// <returns>A hexadecimal color code appropriate for the specified status</returns>
    /// <exception cref="NotImplementedException">Thrown when an unknown status is provided</exception>
    public static string AssessmentStatusToColour(AssessmentStatusEnum status)
    {
        return AssessmentStatusColors.TryGetValue(status, out string? color)
            ? color
            : throw new NotImplementedException($"Unknown assessment status: {status}");
    }

    /// <summary>
    /// Shows a confirmation dialog for assessment status changes
    /// Displays appropriate messaging based on the target status
    /// </summary>
    /// <param name="dialogService">The MudBlazor dialog service instance</param>
    /// <param name="status">The target assessment status for the confirmation</param>
    /// <returns>True if the user confirms the action, false otherwise</returns>
    public static async Task<bool> ConfirmDialog(IDialogService dialogService, AssessmentStatusEnum? status)
    {
        string statusString = status switch
        {
            AssessmentStatusEnum.AdminReview => "Submit For Review",
            AssessmentStatusEnum.InProgress => "Save Assessment",
            AssessmentStatusEnum.UserReview => "Return To The User For Review",
            AssessmentStatusEnum.Completed => "Complete The Assessment",
            _ => "Save Assessment"
        };
        bool? result = await dialogService.ShowMessageBox(
            "Confirm Save",
            statusString,
            yesText: "Confirm",
            cancelText: "Cancel");

        return result ?? false;
    }

    /// <summary>
    /// Shows a generic confirmation dialog for delete operations
    /// </summary>
    /// <param name="dialogService">The MudBlazor dialog service instance</param>
    /// <returns>True if the user confirms the deletion, false otherwise</returns>
    public static async Task<bool> ConfirmDeleteGeneric(IDialogService dialogService)
    {

        bool? result = await dialogService.ShowMessageBox(
            "Confirm Delete",
            "Are you sure you want to delete",
            yesText: "Confirm",
            cancelText: "Cancel");

        return result ?? false;
    }
}

