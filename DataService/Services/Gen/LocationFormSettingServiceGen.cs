/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
namespace DataService.Services
{
    using AutoMapper;
    using Microsoft.Extensions.Configuration;
    using DataService.BaseConnect;
    using DataService.Models.Entities;
    using DataService.Repositories;
    public partial interface ILocationFormSettingService : IBaseService<LocationFormSetting>
    {
    }
    public partial class LocationFormSettingService : BaseService<LocationFormSetting>, ILocationFormSettingService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public LocationFormSettingService(IUnitOfWork unitOfWork, ILocationFormSettingRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
