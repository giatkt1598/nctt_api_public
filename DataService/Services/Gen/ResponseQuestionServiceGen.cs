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
    public partial interface IResponseQuestionService : IBaseService<ResponseQuestion>
    {
    }
    public partial class ResponseQuestionService : BaseService<ResponseQuestion>, IResponseQuestionService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public ResponseQuestionService(IUnitOfWork unitOfWork, IResponseQuestionRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
