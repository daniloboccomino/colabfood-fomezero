using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using globalsolution.fomezero.Persistence;
using globalsolution.fomezero.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace globalsolution.fomezero
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Configure Context dependency injection
            services.AddDbContext<ColabfoodContext>(op =>
                op.UseMySql(Configuration.GetConnectionString("MySQL"),
                ServerVersion.AutoDetect(Configuration.GetConnectionString("MySQL"))));


            // Configure Repositories dependency injection
            services.AddScoped<IAdvertisingRepository, AdvertisingRepository>();
            services.AddScoped<ICharityRepository, CharityRepository>();
            services.AddScoped<IDonationRepository, DonationRepository>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
