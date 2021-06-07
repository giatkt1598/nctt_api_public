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
    public partial interface IUserLoginService : IBaseService<UserLogin>
    {
    }
    public partial class UserLoginService : BaseService<UserLogin>, IUserLoginService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public UserLoginService(IUnitOfWork unitOfWork, IUserLoginRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
