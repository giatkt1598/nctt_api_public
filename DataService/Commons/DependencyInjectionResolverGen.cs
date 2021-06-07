/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
using DataService.BaseConnect;
using DataService.Models.Entities;
using Microsoft.Extensions.DependencyInjection;
using DataService.Services;
using DataService.Repositories;

namespace DataService.Commons
{
    public class DependencyInjectionResolverGen
    {
        public static void Initializer(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<BaseDbContext, NCTTContext>();
        
            services.AddScoped<IFileResponseService, FileResponseService>();
            services.AddScoped<IFileResponseRepository, FileResponseRepository>();
        
            services.AddScoped<IFormService, FormService>();
            services.AddScoped<IFormRepository, FormRepository>();
        
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ILocationRepository, LocationRepository>();
        
            services.AddScoped<ILocationFormSettingService, LocationFormSettingService>();
            services.AddScoped<ILocationFormSettingRepository, LocationFormSettingRepository>();
        
            services.AddScoped<IOptionService, OptionService>();
            services.AddScoped<IOptionRepository, OptionRepository>();
        
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
        
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
        
            services.AddScoped<IQuestionTypeService, QuestionTypeService>();
            services.AddScoped<IQuestionTypeRepository, QuestionTypeRepository>();
        
            services.AddScoped<IResponseService, ResponseService>();
            services.AddScoped<IResponseRepository, ResponseRepository>();
        
            services.AddScoped<IResponseDetailService, ResponseDetailService>();
            services.AddScoped<IResponseDetailRepository, ResponseDetailRepository>();
        
            services.AddScoped<IResponseQuestionService, ResponseQuestionService>();
            services.AddScoped<IResponseQuestionRepository, ResponseQuestionRepository>();
        
            services.AddScoped<IResponseSectionService, ResponseSectionService>();
            services.AddScoped<IResponseSectionRepository, ResponseSectionRepository>();
        
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleRepository, RoleRepository>();
        
            services.AddScoped<IRoleClaimService, RoleClaimService>();
            services.AddScoped<IRoleClaimRepository, RoleClaimRepository>();
        
            services.AddScoped<ISectionService, SectionService>();
            services.AddScoped<ISectionRepository, SectionRepository>();
        
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        
            services.AddScoped<IUserAssignService, UserAssignService>();
            services.AddScoped<IUserAssignRepository, UserAssignRepository>();
        
            services.AddScoped<IUserClaimService, UserClaimService>();
            services.AddScoped<IUserClaimRepository, UserClaimRepository>();
        
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IUserLoginRepository, UserLoginRepository>();
        
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        
            services.AddScoped<IUserTokenService, UserTokenService>();
            services.AddScoped<IUserTokenRepository, UserTokenRepository>();
        }
    }
}
