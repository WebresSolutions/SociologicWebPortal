using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Server.Controllers;
using Casimo.Server.Extensions;
using Casimo.Server.Helpers;
using Casimo.Server.Strings;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;

namespace Casimo.Server;

/// <summary>
/// Main entry point for the Casimo Server application
/// Configures and runs the ASP.NET Core web application with authentication, database, and API endpoints
/// </summary>

public class Program
{
    private static async Task Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.WebHost.UseUrls();

        Console.WriteLine($"Environment Name: '{builder.Environment.EnvironmentName}'");
        if (builder.Environment.EnvironmentName is not StaticStrings.IntegrationEnvName)
        {
            Console.WriteLine("Adding databases and identity services");
            builder.AddDatabases();
            builder.AddIdentityServices();
        }
        else
        {
            Console.WriteLine("Skipping databases and identity services for IntegrationTests");
        }
        builder.AddOtherServices();
        builder.Services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders =
                ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        });
        WebApplication? app = builder.Build();

        app.Use((context, next) =>
        {
            if (context.Request.Scheme != "https")
            {
                context.Request.Scheme = "https";
            }
            return next(context);
        });
        app.UseForwardedHeaders();

        // Configure the HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }
        else
        {
            app.UseDeveloperExceptionPage();
            app.UseWebAssemblyDebugging();
        }

        // Only use HTTPS redirection in development or when not behind a proxy
        if (!app.Environment.IsDevelopment())
        {
            app.UseHttpsRedirection();
        }

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseCors("CorsPolicy");

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapRazorPages();
        app.MapControllers();
        app.MapFallbackToFile("index.html");
        app.AddFacilityEndpoints();
        app.AddFitForPurposeEndpoints();
        app.AddUserManagerEndpoints();


        if (app.Environment.EnvironmentName is not StaticStrings.IntegrationEnvName)
        {
            // Validata the connection
            using (IServiceScope scope = app.Services.CreateScope())
            {
                AuthDBContext? authDB = scope.ServiceProvider.GetRequiredService<AuthDBContext>();
                CasimoDbContext? casimoDB = scope.ServiceProvider.GetRequiredService<CasimoDbContext>();

                if (!casimoDB.IsConnected())
                {
                    throw new Exception("Connection to the Casimo DB failed");
                }
                if (!authDB.IsConnected())
                {
                    throw new Exception("Connection to the Identity DB failed");
                }
            }

            // Seed database with an initial client application and test user
            using (IServiceScope scope = app.Services.CreateScope())
            {
                AuthDBContext? authDB = scope.ServiceProvider.GetRequiredService<AuthDBContext>();
                CasimoDbContext? casimoDB = scope.ServiceProvider.GetRequiredService<CasimoDbContext>();
                RoleManager<IdentityRole>? roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                UserManager<ApplicationUser>? userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                // Call the database seeder (made this awaitable)
                await Seeder.SeedDatabase(roleManager, userManager, casimoDB);
            }
        }

        app.Run();
    }
}