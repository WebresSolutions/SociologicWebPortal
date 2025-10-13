using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Casimo.Server.Helpers;

/// <summary>
/// Helper class for database operations related to user management
/// Provides utility methods for synchronizing users between Identity and Casimo databases
/// </summary>
public static class DbHelpers
{
    /// <summary>
    /// Adds a user to the Casimo database from the Identity system
    /// Creates or updates a Casimo user record based on the Identity user
    /// </summary>
    /// <param name="userManager">The Identity user manager instance</param>
    /// <param name="casimoDB">The Casimo database context</param>
    /// <param name="userName">The username to add to the Casimo database</param>
    /// <param name="isTempUser">Indicates whether the user should be marked as temporary</param>
    /// <returns>A task representing the asynchronous operation</returns>
    public static async Task AddUserToCasimoDB(UserManager<ApplicationUser> userManager, CasimoDbContext casimoDB, string userName, bool isTempUser = false)
    {
        ApplicationUser? user = await userManager.FindByNameAsync(userName);
        if (user is null) return;

        TblUser? casimoUser = await casimoDB.TblUsers.FirstOrDefaultAsync(x => x.IdentityId == user.Id);
        if (casimoUser is not null)
            return;

        casimoUser = await casimoDB.TblUsers.FirstOrDefaultAsync(x => x.Email == user.Email);
        if (casimoUser is not null)
        {
            casimoUser.IdentityId = user.Id;
            await casimoDB.SaveChangesAsync();
            return;
        }

        TblUser newUser = new()
        {
            UserName = user.UserName,
            Firstname = user.UserName,
            Surname = user.UserName,
            Email = user.Email,
            IsActive = true,
            IdentityId = user.Id,
            IsTempUser = isTempUser
        };

        await casimoDB.TblUsers.AddAsync(newUser);
        await casimoDB.SaveChangesAsync();
    }

    /// <summary>
    /// Creates a Casimo user from an Identity application user
    /// Links the Identity user to the Casimo database or creates a new Casimo user record
    /// </summary>
    /// <param name="applicationUser">The Identity application user to create a Casimo user for</param>
    /// <param name="casimoDB">The Casimo database context</param>
    /// <returns>A task containing the created or updated Casimo user record</returns>
    public static async Task<TblUser> AddApplicationUserToCasimoDb(ApplicationUser applicationUser, CasimoDbContext casimoDB)
    {
        TblUser? casimoUser = await casimoDB.TblUsers.FirstOrDefaultAsync(x => x.IdentityId == applicationUser.Id);
        if (casimoUser is not null)
            return casimoUser;

        casimoUser = await casimoDB.TblUsers.FirstOrDefaultAsync(x => x.Email == applicationUser.Email);
        if (casimoUser is not null)
        {
            casimoUser.IdentityId = applicationUser.Id;
            await casimoDB.SaveChangesAsync();
            return casimoUser;
        }

        TblUser newUser = new()
        {
            UserName = applicationUser.UserName,
            Firstname = applicationUser.UserName,
            Surname = applicationUser.UserName,
            Email = applicationUser.Email,
            IsActive = true,
            IdentityId = applicationUser.Id,
        };

        await casimoDB.TblUsers.AddAsync(newUser);
        await casimoDB.SaveChangesAsync();
        return newUser;
    }
}
