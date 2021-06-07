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
    public partial interface IResponseSectionService : IBaseService<ResponseSection>
    {
    }
    public partial class ResponseSectionService : BaseService<ResponseSection>, IResponseSectionService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public ResponseSectionService(IUnitOfWork unitOfWork, IResponseSectionRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
