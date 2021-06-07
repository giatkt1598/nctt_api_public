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
    public partial interface IResponseDetailRepository : IBaseRepository<ResponseDetail>
    {
    }
    public partial class ResponseDetailRepository : BaseRepository<ResponseDetail>, IResponseDetailRepository
    {
         public ResponseDetailRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

