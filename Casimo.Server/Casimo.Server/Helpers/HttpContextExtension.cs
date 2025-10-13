using Casimo.Data.CasimoDB;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Casimo.Server.Helpers;

/// <summary>
/// Extension methods for HttpContext to provide user-related functionality
/// Provides utility methods for extracting user information from HTTP requests
/// </summary>
public static class HttpContextExtension
{
    /// <summary>
    /// Gets the identity user ID from the current HTTP context
    /// Extracts the user identifier from the claims principal
    /// </summary>
    /// <param name="context">The HTTP context containing user claims</param>
    /// <returns>The user identifier as a string</returns>
    /// <exception cref="Exception">Thrown when the user ID claim is not found</exception>
    public static string UserId (this HttpContext context)
    {
        string? userIdClaim = context.User.FindFirstValue(ClaimTypes.NameIdentifier) 
            ?? throw new Exception("Could not find the userId ");
        return userIdClaim;
    }

    /// <summary>
    /// Gets the Casimo user ID from the current HTTP context
    /// Maps the Identity user ID to the corresponding Casimo user record
    /// </summary>
    /// <param name="context">The HTTP context containing user claims</param>
    /// <param name="dbContext">The Casimo database context for user lookup</param>
    /// <returns>A task containing the Casimo user ID</returns>
    /// <exception cref="Exception">Thrown when the user is not found in the Casimo database</exception>
    public static async Task<int> UserCasimoId(this HttpContext context, CasimoDbContext dbContext)
    {
        string userId = context.UserId();
        var tblUsers = await dbContext.TblUsers.ToListAsync();
        TblUser user = await dbContext.TblUsers.FirstOrDefaultAsync(x => x.IdentityId == userId)
            ?? throw new Exception("Failed to find the user associated with the userId");
        return user.UserId;
    }

    /// <summary>
    /// Gets the Casimo username from the current HTTP context
    /// Maps the Identity user ID to the corresponding Casimo user record and returns the username
    /// </summary>
    /// <param name="context">The HTTP context containing user claims</param>
    /// <param name="dbContext">The Casimo database context for user lookup</param>
    /// <returns>A task containing the Casimo username</returns>
    /// <exception cref="Exception">Thrown when the user is not found in the Casimo database</exception>
    public static async Task<string> UserName(this HttpContext context, CasimoDbContext dbContext)
    {
        string userId = context.UserId();
        TblUser user = await dbContext.TblUsers.FirstOrDefaultAsync(x => x.IdentityId == userId)
            ?? throw new Exception("Failed to find the user associated with the userId");
        return user.UserName ?? "";
    }

}
