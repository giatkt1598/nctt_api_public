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
    public partial interface IRoleService : IBaseService<Role>
    {
    }
    public partial class RoleService : BaseService<Role>, IRoleService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public RoleService(IUnitOfWork unitOfWork, IRoleRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
