using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeepsoftCMS.Service.Dto;
using DeepsoftCMS.Web.Models;
using DeepsoftCMS.Web.Areas.Admin.Models;

namespace DeepsoftCMS.Web.Map
{
    public class MapConfig
    {
        public static void Config()
        {

            Mapper.CreateMap<SchemaDto, SchemaListViewModel>()
                .ForMember(dest => dest.TemplateName, exp => exp.MapFrom(orig => orig.Alias != "" ? orig.Alias : orig.FrontView));

            Mapper.CreateMap<SchemaDto, SchemaFormViewModel>();

            Mapper.CreateMap<ArticleDto, ArticleListViewModel>()
                .ForMember(dest => dest.Status, exp => exp.MapFrom(orig => orig.Active ? "Activo" : "Inactivo"));

            Mapper.CreateMap<ArticleDto, ArticleFormViewModel>();

            Mapper.CreateMap<PostDto, PostListViewModel>()
                .ForMember(dest => dest.Status, exp => exp.MapFrom(orig => orig.Active ? "Activo" : "Inactivo"));

            Mapper.CreateMap<PostDto, PostFormViewModel>();

            Mapper.CreateMap<AdmUserDto, AdmUserListViewModel>()
                .ForMember(dest => dest.FullName, exp => exp.MapFrom(orig => orig.Name + " " + orig.LastName));

            Mapper.CreateMap<AdmUserDto, AdmUserFormViewModel>();

            Mapper.CreateMap<WebUserDto, WebUserListViewModel>()
                .ForMember(dest => dest.FullName, exp => exp.MapFrom(orig => orig.Name + " " + orig.LastName));

            Mapper.CreateMap<WebUserDto, WebUserFormViewModel>();

            Mapper.CreateMap<AdmProfileDto, AdmProfileListViewModel>();
            Mapper.CreateMap<AdmProfileDto, AdmProfileFormViewModel>();

        }
    }
}