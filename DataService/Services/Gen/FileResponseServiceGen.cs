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
    public partial interface IFileResponseService : IBaseService<FileResponse>
    {
    }
    public partial class FileResponseService : BaseService<FileResponse>, IFileResponseService
    {
        private readonly string ConnectionString;
        private readonly IMapper Mapper;
        public FileResponseService(IUnitOfWork unitOfWork, IFileResponseRepository repository, 
            IConfiguration configuration, IMapper mapper) : base(unitOfWork, repository) {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
        }
    }
}
