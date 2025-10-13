using System.ComponentModel.DataAnnotations;

namespace Casimo.Shared.Enums;

/// <summary>
/// Enum for tracking the status of an assessment
/// </summary>
public enum AssessmentStatusEnum : int
{
    [Display(Name = "New")]
    New = 1,

    [Display(Name = "In Progress")]
    InProgress = 2,

    [Display(Name = "Under admin review")]
    AdminReview = 3,

    [Display(Name = "For user review")]
    UserReview = 4,

    [Display(Name = "Completed")]
    Completed = 5
}