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
    public partial interface ILocationRepository : IBaseRepository<Location>
    {
    }
    public partial class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
         public LocationRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

