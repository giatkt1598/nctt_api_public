using AutoMapper;
using DataService.Models.Entities;
using DataService.Models.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Models.RequestModels;

namespace WebApi.App_Start
{
    public class AutoMapperConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DataService.Commons.AutoMapperResolver());
                mc.CreateMap<ProjectUpdateModel, ProjectViewModel>();

            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
