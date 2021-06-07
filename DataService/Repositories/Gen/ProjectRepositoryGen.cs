/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
using DataService.BaseConnect;
using DataService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataService.Repositories
{
    public partial interface IProjectRepository : IBaseRepository<Project>
    {
    }
    public partial class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
         public ProjectRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

