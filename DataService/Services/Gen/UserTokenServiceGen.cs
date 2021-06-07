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
    public partial interface IUserTokenService : IBaseService<UserToken>
    {
    }
    public partial class UserTokenService : BaseService<UserToken>, IUserTokenService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public UserTokenService(IUnitOfWork unitOfWork, IUserTokenRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
