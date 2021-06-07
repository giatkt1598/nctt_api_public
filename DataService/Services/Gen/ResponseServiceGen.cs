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
    public partial interface IResponseService : IBaseService<Response>
    {
    }
    public partial class ResponseService : BaseService<Response>, IResponseService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public ResponseService(IUnitOfWork unitOfWork, IResponseRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
