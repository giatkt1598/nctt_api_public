
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
    public partial interface IFileResponseRepository : IBaseRepository<FileResponse>
    {
    }
    public partial class FileResponseRepository : BaseRepository<FileResponse>, IFileResponseRepository
    {
         public FileResponseRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

