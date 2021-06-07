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
    public partial interface IQuestionRepository : IBaseRepository<Question>
    {
    }
    public partial class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
         public QuestionRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

