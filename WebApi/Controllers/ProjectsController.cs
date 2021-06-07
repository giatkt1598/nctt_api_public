using AutoMapper;
using DataService.Enums;
using DataService.Models.Entities;
using DataService.Models.ViewModels;
using DataService.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Constants;
using WebApi.Handlers;
using WebApi.Models.HelperModels;
using WebApi.Models.RequestModels;
using WebApi.Models.ResponseModels;
using WebApi.Utilities;

namespace WebApi.Controllers
{
    [Route("projects")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class ProjectsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProjectService _projectService;
        private readonly IFormService _formService;
        public ProjectsController(IProjectService projectService, 
            IMapper mapper, IFormService formService)
        {
            _mapper = mapper;
            _projectService = projectService;
            _formService = formService;
        }

        /// <summary>
        ///     Get projects by property
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DynamicModelsResponse<ProjectViewModel>))]
        public async Task<IActionResult> GetAsync([FromQuery] ProjectViewModel model,
            [FromQuery] FilterAndPagingAndSortHelperModel pagingSortHelper)
        {
            var requestModel = WebApiUtils.ConvertToDynamicAndPagingHelperModel(model, pagingSortHelper);
            var data = await _projectService.GetDynamicProjectsAsync(requestModel);
            var result = DynamicModelsResponse<ProjectViewModel>.TransformToMe(data, requestModel.Page);
            return Ok(result);
        }

        /// <summary>
        ///     Update project by id
        /// </summary>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProjectViewModel))]
        [ServiceFilter(typeof(ValidationModelAttribute))]
        [ServiceFilter(typeof(ValidationEntityExistsAttribute<Project>))]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute][Required] int id,
            ProjectUpdateModel modelUpdate)
        {
            ProjectViewModel result = await _projectService.UpdateProjectAsync
                (id, _mapper.Map<ProjectViewModel>(modelUpdate));
            return Ok(result);
        }

        /// <summary>
        ///     Get project by id
        /// </summary>
        /// <remarks>
        ///     Get project has 'Actived' = true
        /// </remarks>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProjectViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ServiceFilter(typeof(ValidationModelAttribute))]
        public async Task<IActionResult> GetByIdAsync([FromRoute][Required] int id)
        {
            var project = await _projectService.FirstOrDefaultAsync(x => x.Id == id && x.Actived == true);
            if (project == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ProjectViewModel>(project));
        }

        /// <summary>
        ///     Delete project by id.
        /// </summary>
        /// <remarks>
        ///     Acttualy, set project.Actived = false
        /// </remarks>
        /// <response code="204">Delete success</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            if (await _projectService.DeleteProjectAsync(id))
            {
                return NoContent();
            }
            return NotFound();
        }

        /// <summary>
        ///     Create project
        /// </summary>
        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProjectViewModel))]
        [ServiceFilter(typeof(ValidationModelAttribute))]
        public async Task<IActionResult> CreateProjectAsync([FromBody] ProjectCreateModel modelCreate)
        {
            var result = await _projectService.CreateProjectAsync(_mapper.Map<ProjectViewModel>(modelCreate));
            return Created(new Uri($"{Request.Path}/{result.Id}", UriKind.Relative), result);
        }

        /// <summary>
        ///     Get forms of project
        /// </summary>
        /// <param name="projectId">ProjectId</param>
        /// <param name="helperModel"></param>
        [HttpGet("{id}/forms")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DynamicModelsResponse<FormViewModel>))]
        public async Task<IActionResult> GetFormsByProjectId([FromRoute(Name = "id")][Required] int projectId, 
            [FromQuery] FilterAndPagingAndSortHelperModel helperModel)
        {
            var pagingHelperModel = WebApiUtils.ConvertToPagingHelperModel(helperModel);
            var result = await _formService.GetFormsByProjectIdAsync(projectId, pagingHelperModel);
            var responseModel = DynamicModelsResponse<FormViewModel>.TransformToMe(result, pagingHelperModel.Page);
            return Ok(responseModel);
        }

    }
}
