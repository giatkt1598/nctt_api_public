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
    public partial interface ILocationFormSettingRepository : IBaseRepository<LocationFormSetting>
    {
    }
    public partial class LocationFormSettingRepository : BaseRepository<LocationFormSetting>, ILocationFormSettingRepository
    {
         public LocationFormSettingRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

