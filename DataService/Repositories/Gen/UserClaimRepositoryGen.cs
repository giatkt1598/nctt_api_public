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
    public partial interface IUserClaimRepository : IBaseRepository<UserClaim>
    {
    }
    public partial class UserClaimRepository : BaseRepository<UserClaim>, IUserClaimRepository
    {
         public UserClaimRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

