using DataService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace WebApi.Handlers
{
    public class ValidationEntityExistsAttribute<TEntity> : IActionFilter where TEntity : class
    {
        private readonly NCTTContext _dbContext;

        public ValidationEntityExistsAttribute(NCTTContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string id = context.ActionArguments["id"].ToString();
            var entity = _dbContext.Set<TEntity>()
                .SingleOrDefault($"x => x.Id == {id} && x.Actived == true");
            if (entity == null)
            {
                context.Result = new NotFoundResult();
            }
        }
    }
}
