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
    public partial interface IQuestionTypeRepository : IBaseRepository<QuestionType>
    {
    }
    public partial class QuestionTypeRepository : BaseRepository<QuestionType>, IQuestionTypeRepository
    {
         public QuestionTypeRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

