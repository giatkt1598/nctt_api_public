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
    public partial interface IRoleClaimRepository : IBaseRepository<RoleClaim>
    {
    }
    public partial class RoleClaimRepository : BaseRepository<RoleClaim>, IRoleClaimRepository
    {
         public RoleClaimRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

