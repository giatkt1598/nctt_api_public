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
    public partial interface IRoleRepository : IBaseRepository<Role>
    {
    }
    public partial class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
         public RoleRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

