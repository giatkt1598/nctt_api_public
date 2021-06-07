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
    public partial interface IUserRoleService : IBaseService<UserRole>
    {
    }
    public partial class UserRoleService : BaseService<UserRole>, IUserRoleService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public UserRoleService(IUnitOfWork unitOfWork, IUserRoleRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
