using DataService.Models.Entities;
using DataService.Models.Helpers;
using DataService.Models.ViewModels;
using DataService.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services
{
    public partial interface IProjectService
    {
        public Task<(int, IEnumerable<ProjectViewModel>)> GetDynamicProjectsAsync(DynamicAndPagingHelperModel model);
        public Task<ProjectViewModel> UpdateProjectAsync(int projectId, ProjectViewModel modelUpdate);
        public Task<bool> DeleteProjectAsync(int id);
        public Task<ProjectViewModel> CreateProjectAsync(ProjectViewModel modelCreate);
    }
    public partial class ProjectService
    {
        public async Task<(int, IEnumerable<ProjectViewModel>)> GetDynamicProjectsAsync(DynamicAndPagingHelperModel model)
        {
            return await Task.Run(() =>
            {
                IQueryable<ProjectViewModel> projectViewModels =
                    LinQUtils.GetUsingDictionaryAndFilter<ProjectViewModel, ProjectViewModel>
                    (Mapper.ProjectTo<ProjectViewModel>(Get()), model.PropertyKeyValues, model.Fields);
                var sortedList = LinQUtils.Sort(projectViewModels, model.SortOrderBy, model.SortDirection);
                (int, IQueryable<ProjectViewModel>) result = LinQUtils.PagingIQueryable
                    (sortedList, model.Page, model.Size, model.DefaultSize, model.LimitSize);
                return result;
            });
        }

        public async Task<ProjectViewModel> UpdateProjectAsync(int projectId, ProjectViewModel modelUpdate)
        {
            Project project = await FirstOrDefaultAsync(x => x.Id == projectId);
            if (project == null)
            {
                return null;
            }
            project.Name = modelUpdate.Name ?? project.Name;
            project.Description = modelUpdate.Description ?? project.Description;
            await SaveAsync();
            return Mapper.Map<ProjectViewModel>(project);
        }

        public async Task<bool> DeleteProjectAsync(int id)
        {
            Project project = await FirstOrDefaultAsync(x => x.Id == id && x.Actived == true);
            if (project == null)
            {
                return false;
            }
            project.Actived = false;
            await SaveAsync();
            return true;
        }

        public async Task<ProjectViewModel> CreateProjectAsync(ProjectViewModel modelCreate)
        {
            modelCreate.Actived = true;
            modelCreate.CreatedId = 0;
            Project createdProject = await CreateAsync(Mapper.Map<Project>(modelCreate));
            return Mapper.Map<ProjectViewModel>(createdProject);
        }
    }
}
