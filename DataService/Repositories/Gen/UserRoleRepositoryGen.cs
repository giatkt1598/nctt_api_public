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
    public partial interface IUserRoleRepository : IBaseRepository<UserRole>
    {
    }
    public partial class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
         public UserRoleRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

