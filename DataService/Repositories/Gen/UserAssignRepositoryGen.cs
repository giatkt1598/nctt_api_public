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
    public partial interface IUserAssignRepository : IBaseRepository<UserAssign>
    {
    }
    public partial class UserAssignRepository : BaseRepository<UserAssign>, IUserAssignRepository
    {
         public UserAssignRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

