/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////
using AutoMapper;
using DataService.Models.Entities;
using DataService.Models.ViewModels;

namespace DataService.Commons
{
    public partial class AutoMapperResolver : Profile
    {
        public AutoMapperResolver()
        {
            CreateMap<Form, FormViewModel>();
            CreateMap<FormViewModel, Form>();
            CreateMap<Option, OptionViewModel>();
            CreateMap<OptionViewModel, Option>();
            CreateMap<Project, ProjectViewModel>();
            CreateMap<ProjectViewModel, Project>();
            CreateMap<Question, QuestionViewModel>();
            CreateMap<QuestionViewModel, Question>();
            CreateMap<ResponseDetail, ResponseDetailViewModel>();
            CreateMap<ResponseDetailViewModel, ResponseDetail>();
            CreateMap<Section, SectionViewModel>();
            CreateMap<SectionViewModel, Section>();
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
            CreateMap<UserAssign, UserAssignViewModel>();
            CreateMap<UserAssignViewModel, UserAssign>();
        }
    }
}

