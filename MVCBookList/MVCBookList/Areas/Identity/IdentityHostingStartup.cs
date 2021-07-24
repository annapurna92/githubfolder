using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCBookList.Areas.Identity.Data;
using MVCBookList.Data;

[assembly: HostingStartup(typeof(MVCBookList.Areas.Identity.IdentityHostingStartup))]
namespace MVCBookList.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCBookListContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCBookListContextConnection")));

                services.AddDefaultIdentity<MVCBookListUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<MVCBookListContext>();
            });
        }
    }
}