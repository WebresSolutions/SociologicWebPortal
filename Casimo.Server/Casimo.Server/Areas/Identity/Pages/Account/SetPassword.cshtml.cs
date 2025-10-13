
using Casimo.Data.IdentityData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Casimo.Server.Areas.Identity.Pages.Account;

public class CreatePassword(
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    ILogger<CreatePassword> logger) : PageModel
{
    [BindProperty]
    public required InputModel Input { get; set; }

    [TempData]
    public string? StatusMessage { get; set; }

    [BindProperty]
    public required string Email { get; set; }

    public string? ReturnUrl { get; set; }

    public class InputModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        //    ErrorMessage = "Password must contain at least 8 characters, including uppercase, lowercase, number, and special character.")]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public required string ConfirmPassword { get; set; }
    }

    public async Task<IActionResult> OnGetAsync(string email, string? returnUrl = null)
    {
        // Check if user is already authenticated
        if (User.Identity?.IsAuthenticated == true)
        {
            return RedirectToPage("/Account/Login");
        }

        if (string.IsNullOrEmpty(email))
        {
            return RedirectToPage("/Account/Login");
        }

        ApplicationUser? user = await userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return RedirectToPage("/Account/Login");
        }

        // Check if user already has a password
        if (!string.IsNullOrEmpty(user.PasswordHash))
        {
            return RedirectToPage("/Account/Login");
        }

        Email = email;
        ReturnUrl = returnUrl ?? Url.Content("~/");
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        if (!ModelState.IsValid)
        {
            return Page();
        }

        ApplicationUser? user = await userManager.FindByEmailAsync(Email);
        if (user == null)
        {
            return RedirectToPage("/Account/Login");
        }

        // Check if user already has a password
        if (!string.IsNullOrEmpty(user.PasswordHash))
        {
            return RedirectToPage("/Account/Login");
        }

        try
        {
            // Set the user's password
            IdentityResult result = await userManager.AddPasswordAsync(user, Input.Password);

            if (result.Succeeded)
            {
                logger.LogInformation("User {Email} set their password successfully", Email);

                // Sign in the user
                await signInManager.SignInAsync(user, isPersistent: false);

                StatusMessage = "Your password has been set successfully.";

                // Redirect to the return URL or home page
                return LocalRedirect(returnUrl);
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error setting password for user {Email}", Email);
            ModelState.AddModelError(string.Empty, "An error occurred while setting your password. Please try again.");
            return Page();
        }
    }
}
