using Casimo.Data.CasimoDB;
using Casimo.Data.IdentityData;
using Casimo.Server.ApiData;
using Casimo.Server.Services.Instances;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Smtp2Go.Api;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Casimo.Server;

/// <summary>
/// Static class containing dependency injection configuration methods
/// Provides extension methods for configuring services in the application
/// </summary>
public static class Dependencies
{

    public static void AddDatabases(this WebApplicationBuilder builder)
    {
        Console.WriteLine("Using ENV: " + builder.Environment.EnvironmentName);
        string authConnectionString = builder.Configuration.GetConnectionString("AuthConnection")
            ?? throw new Exception("Connection string 'AuthConnection' not found.");

        builder.Services.AddDbContext<AuthDBContext>(options =>
        {
            // Configure the context to use SQL Server
            options.UseSqlServer(authConnectionString, x => x.MigrationsAssembly("Casimo.Data"));
            // Register the entity sets needed by OpenIddict
            options.UseOpenIddict();
        });

        string casimoConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new Exception("Connection string 'DefaultConnection' not found.");
        builder.Services.AddDbContext<CasimoDbContext>(options => options.UseSqlServer(casimoConnectionString, serverOptions =>
        {
            serverOptions.TranslateParameterizedCollectionsToConstants(); // Enable optimization for SQL WHERE IN clauses otherwise was not working correctly 
            serverOptions.EnableRetryOnFailure(
                maxRetryCount: 3,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
        }));

        Console.WriteLine($"Casimo Connection: {casimoConnectionString}");
        Console.WriteLine($"Auth Connection: {authConnectionString}");
    }

    /// <summary>
    /// Configures identity services including OpenIddict, Entity Framework, and authentication
    /// Sets up the complete authentication and authorization infrastructure
    /// </summary>
    /// <param name="builder">The web application builder to configure</param>
    public static void AddIdentityServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("EmailOptions"));
        builder.Services.Configure<ClientOptions>(builder.Configuration.GetSection("ClientOptions"));

        // Register the Identity services
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<AuthDBContext>()
            .AddDefaultTokenProviders()
            .AddDefaultUI();

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.ExpireTimeSpan = TimeSpan.FromHours(24);
            options.SlidingExpiration = false;
        });

        // OpenIddict offers native integration with Quartz.NET for scheduled tasks
        builder.Services.AddQuartz(options =>
        {
            options.UseSimpleTypeLoader();
            options.UseInMemoryStore();
        });

        // Register the Quartz.NET service
        builder.Services.AddQuartzHostedService(options => options.WaitForJobsToComplete = true);

        // Check if we're in a proxy environment (staging/production behind Cloudflare)
        bool isBehindProxy = builder.Environment.IsStaging() || builder.Environment.IsProduction();

        builder.Services.AddOpenIddict()
            // Register the OpenIddict core components
            .AddCore(options =>
            {
                // Configure OpenIddict to use the Entity Framework Core stores and models
                options.UseEntityFrameworkCore()
                       .UseDbContext<AuthDBContext>();

                // Enable Quartz.NET integration
                options.UseQuartz();
            })
            // Register the OpenIddict client components
            .AddClient(options =>
            {
                // Allow authorization code flow
                options.AllowAuthorizationCodeFlow();

                // Register the signing and encryption credentials
                options.AddDevelopmentEncryptionCertificate()
                       .AddDevelopmentSigningCertificate();

                // Register the ASP.NET Core host and configure options
                options.UseAspNetCore()
                       .EnableStatusCodePagesIntegration()
                       .EnableRedirectionEndpointPassthrough();

                // Register the System.Net.Http integration
                options.UseSystemNetHttp()
                       .SetProductInformation(typeof(Program).Assembly);

                // Configure redirection endpoint manually (required for authorization code flow)
                // This replaces UseWebProviders() when you don't want external providers
                options.SetRedirectionEndpointUris("/callback/login/");
            })
            // Register the OpenIddict server components
            .AddServer(options =>
            {
                // Enable endpoints
                options.SetAuthorizationEndpointUris("connect/authorize")
                       .SetEndSessionEndpointUris("connect/logout")
                       .SetTokenEndpointUris("connect/token")
                       .SetUserInfoEndpointUris("connect/userinfo");

                // Register scopes
                options.RegisterScopes(Scopes.Email, Scopes.Profile, Scopes.Roles);

                // Configure flows
                options.AllowAuthorizationCodeFlow()
                       .AllowRefreshTokenFlow();

                // Register credentials
                options.AddDevelopmentEncryptionCertificate()
                       .AddDevelopmentSigningCertificate();

                // Configure ASP.NET Core options
                options.UseAspNetCore()
                       .EnableAuthorizationEndpointPassthrough()
                       .EnableEndSessionEndpointPassthrough()
                       .EnableStatusCodePagesIntegration()
                       .EnableTokenEndpointPassthrough();
            })
            // Register the OpenIddict validation components
            .AddValidation(options =>
            {
                options.UseLocalServer();
                options.UseAspNetCore();
            });
        builder.Services.AddHostedService<Worker>();

        // Add some policies
        builder.Services.AddAuthorizationBuilder()
            // Add some policies
            .AddPolicy(PolicyConstants.AdminOnly, policy => policy.RequireRole(RoleConstants.AdminUser))
            // Add some policies
            .AddPolicy(PolicyConstants.FullUserOnly, policy => policy.RequireRole(RoleConstants.AdminUser, RoleConstants.FullUser))
            // Add some policies
            .AddPolicy(PolicyConstants.TemporaryUserOnly, policy => policy.RequireRole(RoleConstants.TemporaryUser));

    }

    /// <summary>
    /// Configures additional services including database context, business services, and CORS
    /// Sets up the application's business logic infrastructure
    /// </summary>
    /// <param name="builder">The web application builder to configure</param>
    public static void AddOtherServices(this WebApplicationBuilder builder)
    {
        builder.WebHost.UseStaticWebAssets();

        string smtp2Go = builder.Configuration.GetValue<string>("SMPT2GO")
            ?? throw new Exception("Could not find the smtp 2 go api key");

        // Add the custom services
        builder.Services.AddSingleton<IApiService, Smtp2GoApiService>(x => new Smtp2GoApiService(smtp2Go));
        builder.Services.AddScoped<IFacilityService, FacilityService>();
        builder.Services.AddScoped<IFitForPurposeService, FitForPurposeService>();
        builder.Services.AddScoped<IUserManagerService, UserManagerService>();
        builder.Services.AddScoped<IEmailSender, EmailSender>();
        builder.Services.AddScoped<IMagicLinkService, MagicLinkService>();
        builder.Services.Configure<MagicLinkOptions>(builder.Configuration.GetSection("MagicLink"));

        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.WithOrigins( 
                        "http://localhost:44310",      //Local port
                        "https://localhost:44310",
                        "https://casimo-portal-staging", // Staging environment
                        "https://casimo-portal.casimo.cloud" // Production environment
                    )
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()); // Allow credentials for authentication
        });

    }
}
