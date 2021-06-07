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
    public partial interface IResponseDetailService : IBaseService<ResponseDetail>
    {
    }
    public partial class ResponseDetailService : BaseService<ResponseDetail>, IResponseDetailService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public ResponseDetailService(IUnitOfWork unitOfWork, IResponseDetailRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
