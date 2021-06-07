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
    public partial interface IQuestionTypeService : IBaseService<QuestionType>
    {
    }
    public partial class QuestionTypeService : BaseService<QuestionType>, IQuestionTypeService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public QuestionTypeService(IUnitOfWork unitOfWork, IQuestionTypeRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
