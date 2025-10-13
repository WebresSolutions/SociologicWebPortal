using Casimo.Server.ApiData;
using Microsoft.AspNetCore.Identity.UI.Services;

using Microsoft.Extensions.Options;
using Smtp2Go.Api;
using Smtp2Go.Api.Models.Emails;

namespace Casimo.Server.Services.Instances;

/// <summary>
/// Email service implementation using Smtp2Go API
/// Handles sending emails through the configured SMTP service
/// </summary>
public class EmailSender(IApiService _smptService, ILogger<EmailSender> _logger, IOptions<EmailOptions> _options) : IEmailSender
{
    /// <summary>
    /// Sends an email asynchronously using the configured SMTP service
    /// </summary>
    /// <param name="email">The recipient email address</param>
    /// <param name="subject">The subject line of the email</param>
    /// <param name="body">The HTML body content of the email</param>
    /// <returns>A task representing the asynchronous operation</returns>
    public async Task SendEmailAsync(string email, string subject, string body)
    {
        try
        {
            EmailResponse res = await _smptService.SendEmail(body, subject, _options.Value.FromAddress, [email]);

            if (res.ResponseStatus == "Forbidden")
            {
                _logger.LogError("Failed to send email");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
        }
    }
}
