using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Shared.Constants;
using Microsoft.AspNetCore.Identity;

namespace Casimo.Server.Helpers;

public static class Seeder
{
    /// <summary>
    /// Used to seed the database with temporary users and roles
    /// </summary>
    /// <param name="roleManager">The rolemanager used for managing roles</param>
    /// <param name="userManager">User manager used for creating and updating users</param>
    /// <param name="casimoDB">The casimo database</param>
    /// <returns></returns>
    public static async Task SeedDatabase(
    RoleManager<IdentityRole> roleManager,
    UserManager<ApplicationUser> userManager,
    CasimoDbContext casimoDB)
    {
        try
        {
            // Create roles
            IdentityRole? adminRole = await roleManager.FindByNameAsync(RoleConstants.AdminUser);
            if (adminRole is null)
                _ = await roleManager.CreateAsync(new IdentityRole(RoleConstants.AdminUser));

            IdentityRole? CouncilRole = await roleManager.FindByNameAsync(RoleConstants.FullUser);
            if (CouncilRole is null)
                _ = await roleManager.CreateAsync(new IdentityRole(RoleConstants.FullUser));

            IdentityRole? tempRole = await roleManager.FindByNameAsync(RoleConstants.TemporaryUser);
            if (tempRole is null)
                _ = await roleManager.CreateAsync(new IdentityRole(RoleConstants.TemporaryUser));

            string adminUserName = "admin@test.com";
            string councilUserName = "council@test.com";
            string tempUserName = "temp@test.com";

            // Create test user (admin)
            ApplicationUser? adminUser = await userManager.FindByNameAsync(adminUserName);
            if (adminUser is null)
            {
                ApplicationUser newUser = new()
                {
                    UserName = adminUserName,
                    Email = adminUserName,
                    EmailConfirmed = true,
                    PhoneNumber = "0452339178"
                };

                IdentityResult userCreationResult = await userManager.CreateAsync(newUser, "Abc.123");

                if (!userCreationResult.Succeeded)
                {
                    Console.WriteLine($"Failed to create user {adminUserName}:");
                    foreach (IdentityError error in userCreationResult.Errors)
                    {
                        Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                    }
                    // Log the error and potentially return or throw to stop execution
                    // if user creation is critical for the application to proceed.
                    return; // Stop here if user creation failed
                }

                // Now that user creation is confirmed, assign the newly created user to adminUser variable
                adminUser = newUser; // Or retrieve it again if you prefer, but newUser should have its Id populated

                // Check if user is already in role (good practice, though less critical if creation just happened)
                if (!await userManager.IsInRoleAsync(adminUser, RoleConstants.AdminUser))
                {
                    IdentityResult addToRoleResult = await userManager.AddToRoleAsync(adminUser, RoleConstants.AdminUser);
                    if (!addToRoleResult.Succeeded)
                    {
                        Console.WriteLine($"Failed to add user {adminUser.UserName} to {RoleConstants.AdminUser} role:");
                        foreach (IdentityError error in addToRoleResult.Errors)
                        {
                            Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                        }
                        // Log the error
                    }
                    else
                    {
                        Console.WriteLine($"User {adminUser.UserName} successfully added to {RoleConstants.AdminUser} role.");
                    }
                }
            }
            await DbHelpers.AddUserToCasimoDB(userManager, casimoDB, adminUserName);

            // Repeat the same pattern for council user
            ApplicationUser? councilUser = await userManager.FindByNameAsync(councilUserName);
            if (councilUser is null)
            {
                ApplicationUser newUser = new()
                {
                    UserName = councilUserName,
                    Email = councilUserName,
                    EmailConfirmed = true,
                    PhoneNumber = "0452391078"
                };

                IdentityResult userCreationResult = await userManager.CreateAsync(newUser, "Abc.123");

                if (!userCreationResult.Succeeded)
                {
                    Console.WriteLine($"Failed to create user {councilUserName}:");
                    foreach (IdentityError error in userCreationResult.Errors)
                    {
                        Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                    }
                    return; // Stop here if user creation failed
                }

                councilUser = newUser;

                if (!await userManager.IsInRoleAsync(councilUser, RoleConstants.FullUser))
                {
                    IdentityResult addToRoleResult = await userManager.AddToRoleAsync(councilUser, RoleConstants.FullUser);
                    if (!addToRoleResult.Succeeded)
                    {
                        Console.WriteLine($"Failed to add user {councilUser.UserName} to {RoleConstants.FullUser} role:");
                        foreach (IdentityError error in addToRoleResult.Errors)
                        {
                            Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"User {councilUser.UserName} successfully added to {RoleConstants.FullUser} role.");
                    }
                }
            }
            await DbHelpers.AddUserToCasimoDB(userManager, casimoDB, councilUserName);
            // Repeat the same pattern for council user
            ApplicationUser? tempUser = await userManager.FindByNameAsync(tempUserName);
            if (tempUser is null)
            {
                ApplicationUser newUser = new()
                {
                    UserName = tempUserName,
                    Email = tempUserName,
                    EmailConfirmed = true,
                    PhoneNumber = "0452339107",
                    IsTemporaryUser = true
                };

                IdentityResult userCreationResult = await userManager.CreateAsync(newUser, "Abc.123");

                if (!userCreationResult.Succeeded)
                {
                    Console.WriteLine($"Failed to create user {councilUserName}:");
                    foreach (IdentityError error in userCreationResult.Errors)
                    {
                        Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                    }
                    return;
                }

                tempUser = newUser;

                if (!await userManager.IsInRoleAsync(tempUser, RoleConstants.TemporaryUser))
                {
                    IdentityResult addToRoleResult = await userManager.AddToRoleAsync(tempUser, RoleConstants.TemporaryUser);
                    if (!addToRoleResult.Succeeded)
                    {
                        Console.WriteLine($"Failed to add user {councilUser.UserName} to {RoleConstants.TemporaryUser} role:");
                        foreach (IdentityError error in addToRoleResult.Errors)
                        {
                            Console.WriteLine($"- Code: {error.Code}, Description: {error.Description}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"User {councilUser.UserName} successfully added to {RoleConstants.TemporaryUser} role.");
                    }
                }
            }
            await DbHelpers.AddUserToCasimoDB(userManager, casimoDB, tempUserName, true);

        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            throw;
        }
    }
}
