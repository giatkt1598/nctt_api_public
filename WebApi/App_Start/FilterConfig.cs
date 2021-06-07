﻿using DataService.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Customs;
using WebApi.Handlers;

namespace WebApi.App_Start
{
    public class FilterConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                // Disable auto return BadRequest(ModelState) if !ModelState.IsValid
                options.SuppressModelStateInvalidFilter = true;
                // Disable auto set schema ProblemDetail for error responses (HttpStatusCode = 4xx)
                //options.SuppressMapClientErrors = true;
            });
            services.AddMvc(options =>
            {
                options.ValueProviderFactories.Add(new SnakeCaseQueryValueProviderFactory());
            });

            services.AddControllers(options =>
            {
                options.Filters.Add<ExceptionHandlingFilter>();
            });
            services.AddScoped<ValidationModelAttribute>();
            services.AddScoped<ValidationEntityExistsAttribute<Project>>();
        }
    }
}
