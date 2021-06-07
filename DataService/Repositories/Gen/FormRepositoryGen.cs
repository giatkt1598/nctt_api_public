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
    public partial interface IFormRepository : IBaseRepository<Form>
    {
    }
    public partial class FormRepository : BaseRepository<Form>, IFormRepository
    {
         public FormRepository(BaseDbContext dbContext) : base(dbContext)
         {
         }
    }
}

