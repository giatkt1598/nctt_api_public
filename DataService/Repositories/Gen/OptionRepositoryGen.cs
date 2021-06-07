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
    public partial interface IOptionRepository : IBaseRepository<Option>
    {
    }
    public partial class OptionRepository : BaseRepository<Option>, IOptionRepository
    {
         public OptionRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

