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
    public partial interface IResponseQuestionRepository : IBaseRepository<ResponseQuestion>
    {
    }
    public partial class ResponseQuestionRepository : BaseRepository<ResponseQuestion>, IResponseQuestionRepository
    {
         public ResponseQuestionRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

