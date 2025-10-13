[assembly: HostingStartup(typeof(Casimo.Server.Areas.Identity.IdentityHostingStartup))]
namespace Casimo.Server.Areas.Identity;

public class IdentityHostingStartup : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
        });
    }
}
