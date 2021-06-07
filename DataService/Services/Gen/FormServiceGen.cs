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
    public partial interface IFormService : IBaseService<Form>
    {
    }
    public partial class FormService : BaseService<Form>, IFormService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public FormService(IUnitOfWork unitOfWork, IFormRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
