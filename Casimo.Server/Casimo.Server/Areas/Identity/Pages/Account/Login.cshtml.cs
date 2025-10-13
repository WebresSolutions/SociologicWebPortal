using Casimo.Data.IdentityData;
using Casimo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;

namespace Casimo.Server.Areas.Identity.Pages.Account;

public class LoginModel(
    ILogger<LoginModel> logger,
    UserManager<ApplicationUser> userManager,
    IEmailSender emailSender,
    IMagicLinkService magicLinkService) : PageModel
{
    /// <summary>
    /// The input model
    /// </summary>
    [BindProperty]
    public required InputModel Input { get; set; }

    /// <summary>
    /// The return url
    /// </summary>
    public required string ReturnUrl { get; set; }

    /// <summary>
    /// The error message
    /// </summary>
    [TempData]
    public required string ErrorMessage { get; set; }

    /// <summary>
    /// The success message
    /// </summary>
    public string? SuccessMessage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool HideLoginButtons { get; set; } = false;

    public async Task OnGetAsync(string? returnUrl = null)
    {
        if (!string.IsNullOrEmpty(ErrorMessage))
        {
            ModelState.AddModelError(string.Empty, ErrorMessage);
        }

        returnUrl ??= Url.Content("~/");

        // Clear the existing external cookie to ensure a clean login process
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        ReturnUrl = returnUrl;
    }

    /// <summary>
    /// Ensures that the entered email exists and if it does then redirect to the desired login page
    /// </summary>
    /// <param name="returnUrl"></param>
    /// <returns></returns>
    public async Task<IActionResult> OnPostEmailAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        // Look up the user password 
        ApplicationUser? applicationUser = await userManager.FindByEmailAsync(Input.Email);

        if (applicationUser is null)
        {
            logger.LogWarning($"Attempted passwordless login for non-existent or unconfirmed email: {Input.Email}");
            ModelState.AddModelError(string.Empty, "That email address does not exist.");
            return Page();
        }

        // Redirect to the email only login
        if (applicationUser.IsTemporaryUser is true)
        {
            if (applicationUser.TemporaryUserExpiry < DateTime.UtcNow)
            {
                logger.LogWarning($"Access expired for email: {Input.Email}");
                ModelState.AddModelError(string.Empty, "Your login has expired please contact the administrator");
                return Page();
            }

            return await TempUserLogin(applicationUser, returnUrl);
        }
        // Redirect to the regular login
        else
        {
            // Check if user has a password set
            if (string.IsNullOrEmpty(applicationUser.PasswordHash))
            {
                // Redirect user to set their password
                logger.LogInformation($"User {Input.Email} needs to set password, redirecting to SetPassword page");
                return RedirectToPage("./SetPassword", new { email = Input.Email, returnUrl = returnUrl });
            }

            return RedirectToPage("./PasswordLogin", new { ReturnUrl = returnUrl, Input.RememberMe, Input.Email });
        }
    }

    /// <summary>
    /// Sends the tempory user a login email
    /// </summary>
    /// <param name="user">The user logging in</param>
    /// <param name="returnUrl">The optional return url</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<IActionResult> TempUserLogin(ApplicationUser user, string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        try
        {
            // Generate a magic login token with 10-minute expiration
            string encodedToken = await magicLinkService.GenerateMagicLinkTokenAsync(user, 10);

            string callbackUrl = Url.Page(
                "/Account/LoginWithMagicLink",
                pageHandler: null,
                values: new { userId = user.Id, token = encodedToken, returnUrl },
                protocol: Request.Scheme) ?? throw new Exception("Failed to create the magic link");

            // Send the magic link email
            await emailSender.SendEmailAsync(
                Input.Email,
                "Your Magic Login Link for Casimo",
                $"Please log in to Casimo by clicking this link: <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Login to Casimo Web Portal</a>.<br><br>" +
                $"<strong>This link will expire in 10 minutes.</strong>");

            logger.LogWarning($"Magic login link sent to {Input.Email} with 10-minute expiration");
            SuccessMessage = "Success! A login link has been sent to your email address. Please check your inbox. The link will expire in 10 minutes.";
            HideLoginButtons = true;
            return Page();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Failed to send magic login link to {Input.Email}");
            ModelState.AddModelError(string.Empty, "Failed to send login link. Please try again or contact support.");
            return Page();
        }
    }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}