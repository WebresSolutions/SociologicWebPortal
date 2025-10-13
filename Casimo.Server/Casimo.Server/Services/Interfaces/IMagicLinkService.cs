using Casimo.Data.IdentityData;

namespace Casimo.Server.Services.Interfaces;

/// <summary>
/// Service for handling magic link authentication with expiration
/// </summary>
public interface IMagicLinkService
{
    /// <summary>
    /// Generates a magic link token with expiration
    /// </summary>
    /// <param name="user">The user to generate the token for</param>
    /// <param name="expirationMinutes">Number of minutes until expiration (default: 10)</param>
    /// <returns>Encoded token with expiration</returns>
    Task<string> GenerateMagicLinkTokenAsync(ApplicationUser user, int expirationMinutes = 10);

    /// <summary>
    /// Validates a magic link token and checks expiration
    /// </summary>
    /// <param name="user">The user to validate the token for</param>
    /// <param name="encodedToken">The encoded token from the URL</param>
    /// <returns>True if token is valid and not expired</returns>
    Task<bool> ValidateMagicLinkTokenAsync(ApplicationUser user, string encodedToken);

    /// <summary>
    /// Gets the expiration time from a token
    /// </summary>
    /// <param name="encodedToken">The encoded token</param>
    /// <returns>Expiration time or null if invalid</returns>
    DateTime? GetTokenExpirationTime(string encodedToken);
}
