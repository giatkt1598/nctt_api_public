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
    public partial interface IUserClaimService : IBaseService<UserClaim>
    {
    }
    public partial class UserClaimService : BaseService<UserClaim>, IUserClaimService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public UserClaimService(IUnitOfWork unitOfWork, IUserClaimRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
