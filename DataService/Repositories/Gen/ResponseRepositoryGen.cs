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
    public partial interface IResponseRepository : IBaseRepository<Response>
    {
    }
    public partial class ResponseRepository : BaseRepository<Response>, IResponseRepository
    {
         public ResponseRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

