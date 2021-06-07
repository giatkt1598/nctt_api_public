using DataService.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataService.Repositories;
using DataService.BaseConnect;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using DataService.Models.Helpers;
using DataService.Utilities;

namespace DataService.Services
{
    public partial interface IFormService
    {
        public Task<(int, IEnumerable<FormViewModel>)> GetFormsByProjectIdAsync
            (int projectId, PagingAndSortHelperModel pagingHelper);
    }
    public partial class FormService
    {
        private readonly IProjectRepository _projectRepository;

        public FormService(IUnitOfWork unitOfWork, IFormRepository repository,
            IConfiguration configuration, IMapper mapper, 
            IProjectRepository projectRepository) : base(unitOfWork, repository)
        {
            ConnectionString = configuration.GetConnectionString("Default");
            this.Mapper = mapper;
            _projectRepository = projectRepository;
        }
        public async Task<(int, IEnumerable<FormViewModel>)> GetFormsByProjectIdAsync
            (int projectId, PagingAndSortHelperModel pagingSort)
        {
            if (await _projectRepository.FirstOrDefaultAsyn(x => x.Id == projectId && x.Actived == true) != null)
            {
                var formViewModels = Mapper.ProjectTo<FormViewModel>(Get()
                    .Where(x => x.ProjectId == projectId && x.Actived == true));
                var filteredList = LinQUtils.GetUsingFilter<FormViewModel, FormViewModel>
                    (formViewModels, pagingSort.Fields);
                var sortedList = LinQUtils.Sort(filteredList, pagingSort.SortOrderBy, pagingSort.SortDirection);
                var result = LinQUtils.PagingIQueryable(sortedList, pagingSort.Page, 
                    pagingSort.Size, pagingSort.DefaultSize, pagingSort.LimitSize);

                return result;
            }
            return (0, new List<FormViewModel>());
        }
    }
}
