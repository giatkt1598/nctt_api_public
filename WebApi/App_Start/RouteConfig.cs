using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Extensions;
using static WebApi.Constants.ApiConfig;

namespace WebApi.App_Start
{
    public static class RouteConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.UseCentralRoutePrefix(new RouteAttribute($"api/{ApiVersion}"));
            });
        }
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
        }
    }
}
