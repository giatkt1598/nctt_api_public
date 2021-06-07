using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.App_Start;

namespace WebApi
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
            CorsConfig.ConfigureServices(services);
            FilterConfig.ConfigureServices(services);
            DependencyInjectionResolver.ConfigureServices(services, Configuration);
            JsonFormatConfig.ConfigureServices(services);
            SwaggerConfig.ConfigureServices(services);
            AutoMapperConfig.ConfigureServices(services);
            AuthConfig.ConfigureServices(services);
            RouteConfig.ConfigureServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            CorsConfig.Configure(app, env);

            SwaggerConfig.Configure(app, env);

            ErrorHandlerConfig.Configure(app, env);

            RouteConfig.Configure(app, env);

            AuthConfig.Configure(app, env);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
