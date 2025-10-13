namespace Casimo.Shared.ApiModels.User;

/// <summary>
/// Data transfer object for inviting users to assessment lists
/// Immutable record containing email addresses and list identifier for bulk invitations
/// </summary>
/// <param name="Emails">Array of email addresses to send invitations to</param>
/// <param name="ListId">The unique identifier of the assessment list to invite users to</param>
public record UserAssessmentListInvite(string[] Emails, int ListId);