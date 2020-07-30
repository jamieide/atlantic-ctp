using System;
using AtlanticCovidTracker.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AtlanticCovidTracker.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RouteOptions>(config =>
            {
                config.LowercaseUrls = true;
            });

            // TODO understand response caching
            //services.AddResponseCaching();
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddHttpClient<IAtlanticCovidTrackerClient, AtlanticCovidTrackerClient>(config =>
            {
                // TODO move to appsettings
                config.BaseAddress = new Uri("https://covidtracking.com/");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
