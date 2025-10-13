namespace Casimo.Server.ApiData;

/// <summary>
/// Configuration options for magic link authentication
/// </summary>
public class MagicLinkOptions
{
    /// <summary>
    /// Default expiration time in minutes for magic link tokens
    /// </summary>
    public int DefaultExpirationMinutes { get; set; } = 10;

    /// <summary>
    /// Maximum expiration time in minutes for magic link tokens
    /// </summary>
    public int MaxExpirationMinutes { get; set; } = 60;

    /// <summary>
    /// Whether to include security hash in tokens for additional security
    /// </summary>
    public bool IncludeSecurityHash { get; set; } = true;
}