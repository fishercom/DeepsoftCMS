using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepsoftCMS.Repository.Entity;
using DeepsoftCMS.Service.Dto;

namespace DeepsoftCMS.Service.Map
{
    public class MapConfig
    {
        public static void Config()
        {
            Mapper.CreateMap<AdmModule, AdmModuleDto>()
                .ForMember(dest => dest.MenuId,
                map => map.MapFrom(orig => orig.Id))
                .ForMember(dest => dest.Controller, map =>
                map.MapFrom(orig => string.IsNullOrEmpty(orig.Controller) ? string.Empty : orig.Controller));

            Mapper.CreateMap<AdmProfile, AdmProfileDto>()
                .ForMember(dest => dest.AdmProfileId,
                map => map.MapFrom(orig => orig.Id));

            Mapper.CreateMap<AdmProfileDto, AdmProfile>()
                .ForMember(dest => dest.Id,
                map => map.MapFrom(orig => orig.AdmProfileId));

            Mapper.CreateMap<AdmUser, AdmUserDto>()
                .ForMember(dest => dest.UserId,
                map => map.MapFrom(orig => orig.Id));

            Mapper.CreateMap<AdmUserDto, AdmUser>()
                .ForMember(dest => dest.Id,
                map => map.MapFrom(orig => orig.UserId));

            Mapper.CreateMap<WebUser, WebUserDto>()
                .ForMember(dest => dest.UserId,
                map => map.MapFrom(orig => orig.Id));

            Mapper.CreateMap<WebUserDto, WebUser>()
                .ForMember(dest => dest.Id,
                map => map.MapFrom(orig => orig.UserId));

            Mapper.CreateMap<SchemaTemplateDto, SchemaTemplateDto>();

            Mapper.CreateMap<CmsSchema, SchemaDto>()
                .ForMember(dest => dest.SchemaId,
                map => map.MapFrom(orig => orig.Id))
                .ForMember(dest => dest.Alias, map =>
                map.MapFrom(orig => string.IsNullOrEmpty(orig.Name) ? string.Empty : orig.Name));

            Mapper.CreateMap<SchemaDto, CmsSchema>()
                .ForMember(dest => dest.Id,
                map => map.MapFrom(orig => orig.SchemaId));

            Mapper.CreateMap<CmsArticle, ArticleDto>()
                .ForMember(dest => dest.ArticleId, map => map.MapFrom(orig => orig.Id));

            Mapper.CreateMap<ArticleDto, CmsArticle>()
                .ForMember(dest => dest.Id, map => map.MapFrom(orig => orig.ArticleId));

            Mapper.CreateMap<Post, PostDto>()
                .ForMember(dest => dest.PostId,
                map => map.MapFrom(orig => orig.Id));

            Mapper.CreateMap<PostDto, Post>()
                .ForMember(dest => dest.Id,
                map => map.MapFrom(orig => orig.PostId));

            Mapper.CreateMap<Comment, CommentDto>();
        }
    }
}
