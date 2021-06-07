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
    public partial interface IUserLoginRepository : IBaseRepository<UserLogin>
    {
    }
    public partial class UserLoginRepository : BaseRepository<UserLogin>, IUserLoginRepository
    {
         public UserLoginRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

