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
    public partial interface IProjectService : IBaseService<Project>
    {
    }
    public partial class ProjectService : BaseService<Project>, IProjectService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public ProjectService(IUnitOfWork unitOfWork, IProjectRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
