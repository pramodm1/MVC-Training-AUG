using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Training_Dec21.Data;

[assembly: HostingStartup(typeof(Training_Dec21.Areas.Identity.IdentityHostingStartup))]
namespace Training_Dec21.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Training_Dec21Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Training_Dec21ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Training_Dec21Context>();
            });
        }
    }
}