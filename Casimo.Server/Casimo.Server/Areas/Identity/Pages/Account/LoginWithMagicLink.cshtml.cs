using Casimo.Data.IdentityData;
using Casimo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Casimo.Server.Areas.Identity.Pages.Account
{
    public class LoginWithMagicLinkModel(
        UserManager<ApplicationUser> _userManager,
        SignInManager<ApplicationUser> _signInManager,
        IMagicLinkService _magicLinkService) : PageModel
    {
        /// <summary>
        /// The token which is generated from the magic link
        /// </summary>
        public required string Token { get; set; }

        /// <summary>
        /// The user which is logging int
        /// </summary>
        public required string UserId { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string token, string? returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                return RedirectToPage("/Account/Login");
            }

            ApplicationUser? user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                return RedirectToPage("/Account/Login");
            }

            // Validate the magic link token using the service
            bool isValid = await _magicLinkService.ValidateMagicLinkTokenAsync(user, token);
            if (!isValid)
            {
                // Check if token expired
                DateTime? expirationTime = _magicLinkService.GetTokenExpirationTime(token);
                if (expirationTime.HasValue && DateTime.UtcNow > expirationTime.Value)
                    return RedirectToPage("/Account/Login", new { ErrorMessage = "Your login link has expired. Please request a new one." });
                
                return RedirectToPage("/Account/Login", new { ErrorMessage = "Invalid or expired login link. Please request a new one." });
            }

            // Sign in the user (same as regular login)
            await _signInManager.SignInAsync(user, isPersistent: false);

            // Simple redirect (same as regular login) - THIS IS THE KEY
            return LocalRedirect(returnUrl);
        }
    }
}
