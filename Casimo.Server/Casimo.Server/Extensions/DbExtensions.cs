using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Microsoft.EntityFrameworkCore.Internal;

namespace Casimo.Server.Extensions;

/// <summary>
/// Extension methods for database contexts to provide additional functionality
/// Provides utility methods for database connection validation
/// </summary>
public static class DbExtensions
{
    /// <summary>
    /// Checks if the Casimo database context can establish a connection
    /// Tests the database connectivity without throwing exceptions
    /// </summary>
    /// <param name="dbContext">The Casimo database context to test</param>
    /// <returns>True if the database is accessible, false otherwise</returns>
    public static bool IsConnected(this CasimoDbContext dbContext)
    {
        try
        {
            bool connRes = dbContext.Database.CanConnect();
            return connRes;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// Checks if the Auth database context can establish a connection
    /// Tests the database connectivity without throwing exceptions
    /// </summary>
    /// <param name="dbContext">The Auth database context to test</param>
    /// <returns>True if the database is accessible, false otherwise</returns>
    public static bool IsConnected(this AuthDBContext dbContext)
    {
        try
        {
            return dbContext.Database.CanConnect();
        }
        catch (Exception)
        {
            return false;
        }
    }

}
