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
    public partial interface IUserAssignService : IBaseService<UserAssign>
    {
    }
    public partial class UserAssignService : BaseService<UserAssign>, IUserAssignService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public UserAssignService(IUnitOfWork unitOfWork, IUserAssignRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
