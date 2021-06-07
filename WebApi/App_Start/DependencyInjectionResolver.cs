using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Handlers;

namespace WebApi.App_Start
{
    public class DependencyInjectionResolver
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            DataService.Commons.DependencyInjectionResolverGen.Initializer(services);
            services.AddDbContext<DataService.Models.Entities.NCTTContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Default"));
            });

        }
    }
}
