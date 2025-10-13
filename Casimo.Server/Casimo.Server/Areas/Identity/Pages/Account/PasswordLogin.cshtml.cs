using Casimo.Data.IdentityData;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Casimo.Server.Areas.Identity.Pages.Account;

public class PasswordLoginModel(
    SignInManager<ApplicationUser> signInManager,
    ILogger<LoginModel> logger,
    UserManager<ApplicationUser> userManager) : PageModel
{
    [BindProperty]
    public string? ReturnUrl { get; set; }

    [BindProperty]
    public string? Email { get; set; }

    [BindProperty]
    public bool RememberMe { get; set; }

    [BindProperty]
    public required PasswordLoginInputModel Input { get; set; }

    [TempData]
    public required string ErrorMessage { get; set; }

    public async Task OnGetAsync(string email, bool rememberMe, string returnUrl)
    {
        if (!string.IsNullOrEmpty(ErrorMessage))
        {
            ModelState.AddModelError(string.Empty, ErrorMessage);
        }

        returnUrl ??= Url.Content("~/");

        // Clear the existing external cookie to ensure a clean login process
        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        Email = email;
        RememberMe = rememberMe;
        ReturnUrl = returnUrl;

        // Initialize Input if it's null (required property)
        Input ??= new PasswordLoginInputModel
        {
            Password = ""
        };
    }

    public async Task<IActionResult> OnPostLoginAsync()
    {
        string returnUrl = ReturnUrl ?? Url.Content("~/");

        if (!ModelState.IsValid)
            return Page();

        try
        {
            // Use the email from the bound Email property, not from Input
            SignInResult result = await signInManager.PasswordSignInAsync(
                Email!,
                Input.Password,
                RememberMe,
                lockoutOnFailure: false);

            // Get the user
            ApplicationUser? user = await userManager.FindByNameAsync(Email!);
            if (user is null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

            if (result.Succeeded)
            {
                if (user.TemporaryUserExpiry > DateTime.UtcNow && user.IsTemporaryUser)
                {
                    logger.LogWarning("User account access has expired");
                    return RedirectToPage("./Lockout");
                }

                logger.LogInformation("User logged in.");
                return LocalRedirect(returnUrl);
            }

            if (result.RequiresTwoFactor)
            {
                return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe });
            }

            if (result.IsLockedOut)
            {
                logger.LogWarning("User account locked out.");
                return RedirectToPage("./Lockout");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Login failed");
            ModelState.AddModelError(string.Empty, "Failed to login");
            return Page();
        }
    }

    public class PasswordLoginInputModel
    {
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}