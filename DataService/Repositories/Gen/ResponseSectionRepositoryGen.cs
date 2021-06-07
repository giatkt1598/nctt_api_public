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
    public partial interface IResponseSectionRepository : IBaseRepository<ResponseSection>
    {
    }
    public partial class ResponseSectionRepository : BaseRepository<ResponseSection>, IResponseSectionRepository
    {
         public ResponseSectionRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

