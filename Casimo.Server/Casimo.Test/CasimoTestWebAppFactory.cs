using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Server;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Casimo.Test;

public class CasimoTestWebAppFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // Set the environment to "IntegrationTests" to trigger the in-memory database setup.
        builder.UseEnvironment("IntegrationTests");

        // Override configuration to prevent SQL Server connection string errors
        builder.ConfigureAppConfiguration((context, config) =>
        {
            config.AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["ConnectionStrings:AuthConnection"] = "InMemory",
                ["ConnectionStrings:DefaultConnection"] = "InMemory"
            });
        });

        // Override database services to use in-memory databases for testing
        builder.ConfigureServices((context, services) =>
        {
            // Remove ALL existing database context registrations to avoid conflicts
            List<ServiceDescriptor> descriptorsToRemove = [.. services.Where(d =>
                d.ServiceType == typeof(CasimoDbContext) ||
                d.ServiceType == typeof(AuthDBContext) ||
                d.ServiceType == typeof(DbContextOptions<CasimoDbContext>) ||
                d.ServiceType == typeof(DbContextOptions<AuthDBContext>) ||
                (d.ServiceType.IsGenericType && d.ServiceType.GetGenericTypeDefinition() == typeof(DbContextOptions<>)) ||
                d.ServiceType.Name.Contains("DbContext") ||
                d.ServiceType.Name.Contains("EntityFramework")
            )];

            foreach (ServiceDescriptor? descriptor in descriptorsToRemove)
            {
                services.Remove(descriptor);
            }

            // Add in-memory database contexts
            services.AddDbContext<CasimoDbContext>(options =>
            {
                options.UseInMemoryDatabase("CasimoTestDb");
            });

            services.AddDbContext<AuthDBContext>(options =>
            {
                options.UseInMemoryDatabase("AuthTestDb");
                options.UseOpenIddict();
            });
        });
    }
}
