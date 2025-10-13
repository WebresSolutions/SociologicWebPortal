using Casimo.Data.IdentityData;
using Casimo.Server.ApiData;
using Casimo.Server.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Casimo.Server.Services.Instances;

/// <summary>
/// Service for handling magic link authentication with expiration
/// </summary>
public class MagicLinkService : IMagicLinkService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<MagicLinkService> _logger;
    private readonly MagicLinkOptions _options;

    public MagicLinkService(UserManager<ApplicationUser> userManager, ILogger<MagicLinkService> logger, IOptions<MagicLinkOptions> options)
    {
        _userManager = userManager;
        _logger = logger;
        _options = options.Value;
    }

    /// <summary>
    /// Generates a magic link token with expiration
    /// </summary>
    public async Task<string> GenerateMagicLinkTokenAsync(ApplicationUser user, int expirationMinutes = 10)
    {
        try
        {
            // Validate expiration time
            if (expirationMinutes <= 0 || expirationMinutes > _options.MaxExpirationMinutes)
                expirationMinutes = _options.DefaultExpirationMinutes;

            // Generate the base token using ASP.NET Identity
            string baseToken = await _userManager.GenerateUserTokenAsync(user, "Default", "login");

            // Create expiration timestamp
            DateTime expirationTime = DateTime.UtcNow.AddMinutes(expirationMinutes);
            string expirationTimestamp = expirationTime.ToString("yyyy-MM-ddTHH:mm:ssZ");

            string tokenData;

            if (_options.IncludeSecurityHash)
            {
                // Create a secure hash of the user ID and expiration for additional security
                string securityHash = GenerateSecurityHash(user.Id, expirationTimestamp);

                // Combine all parts: baseToken|expiration|securityHash
                tokenData = $"{baseToken}|{expirationTimestamp}|{securityHash}";
            }
            else
            {
                // Combine parts without security hash: baseToken|expiration
                tokenData = $"{baseToken}|{expirationTimestamp}";
            }

            // Encode the complete token
            string encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(tokenData));

            _logger.LogInformation($"Generated magic link token for user {user.Email} with expiration at {expirationTime} ({expirationMinutes} minutes)");

            return encodedToken;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to generate magic link token for user {user.Email}");
            throw;
        }
    }

    /// <summary>
    /// Validates a magic link token and checks expiration
    /// </summary>
    public async Task<bool> ValidateMagicLinkTokenAsync(ApplicationUser user, string encodedToken)
    {
        try
        {
            // Decode the token
            string decodedToken;
            try
            {
                decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(encodedToken));
            }
            catch
            {
                _logger.LogWarning($"Invalid token format for user {user.Email}");
                return false;
            }

            // Split token parts
            string[] tokenParts = decodedToken.Split('|');
            if (tokenParts.Length is < 2 or > 3)
            {
                _logger.LogWarning($"Invalid token structure for user {user.Email}");
                return false;
            }

            string baseToken = tokenParts[0];
            string expirationTimestamp = tokenParts[1];
            string? securityHash = tokenParts.Length == 3 ? tokenParts[2] : null;

            // Validate expiration
            if (!DateTime.TryParse(expirationTimestamp, null, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out DateTime expirationTime))
            {
                _logger.LogWarning($"Invalid expiration timestamp for user {user.Email}");
                return false;
            }

            if (DateTime.UtcNow > expirationTime)
            {
                _logger.LogInformation($"Token expired for user {user.Email} at {expirationTime}");
                return false;
            }

            // Validate security hash if enabled
            if (_options.IncludeSecurityHash && !string.IsNullOrEmpty(securityHash))
            {
                string expectedHash = GenerateSecurityHash(user.Id, expirationTimestamp);
                if (securityHash != expectedHash)
                {
                    _logger.LogWarning($"Security hash mismatch for user {user.Email}");
                    return false;
                }
            }

            // Validate the base token with ASP.NET Identity
            bool isValidToken = await _userManager.VerifyUserTokenAsync(user, "Default", "login", baseToken);

            if (isValidToken)
                _logger.LogInformation($"Magic link token validated successfully for user {user.Email}");
            else
                _logger.LogWarning($"Invalid base token for user {user.Email}");

            return isValidToken;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Error validating magic link token for user {user.Email}");
            return false;
        }
    }

    /// <summary>
    /// Gets the expiration time from a token
    /// </summary>
    public DateTime? GetTokenExpirationTime(string encodedToken)
    {
        try
        {
            string decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(encodedToken));
            string[] tokenParts = decodedToken.Split('|');

            return tokenParts.Length >= 2 && DateTime.TryParse(tokenParts[1], out DateTime expirationTime) ? expirationTime : null;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Generates a secure hash for additional token security
    /// </summary>
    private static string GenerateSecurityHash(string userId, string expirationTimestamp)
    {
        string dataToHash = $"{userId}:{expirationTimestamp}";
        byte[] hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(dataToHash));
        return Convert.ToBase64String(hashBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
    }
}
