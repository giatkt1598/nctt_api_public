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
    public partial interface IUserTokenRepository : IBaseRepository<UserToken>
    {
    }
    public partial class UserTokenRepository : BaseRepository<UserToken>, IUserTokenRepository
    {
         public UserTokenRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

