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
    public partial interface ISectionRepository : IBaseRepository<Section>
    {
    }
    public partial class SectionRepository : BaseRepository<Section>, ISectionRepository
    {
         public SectionRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

