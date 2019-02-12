using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DeepsoftCMS.Repository.DDDContext;
using DeepsoftCMS.Repository.Entity;
using DeepsoftCMS.Service.Dto;

namespace DeepsoftCMS.Service
{
    public class ServiceArticle
    {
        private ICMSRepository context;

        public ServiceArticle()
        {
            context = new EFCMSRepository();
        }

        public IEnumerable<Dto.ArticleDto> GetList(Nullable<int> ArticleParentId)
        {
            return context.ArticleRepository.GetAll().Where(e => e.ArticleParentId == ArticleParentId).ProjectTo<Dto.ArticleDto>();
        }

        public IEnumerable<Dto.ArticleDto> GetWebList(Nullable<int> ArticleParentId)
        {
            return context.ArticleRepository.GetAll().Where(e => e.ArticleParentId == ArticleParentId && e.Active==true).ProjectTo<Dto.ArticleDto>();
        }

        public IEnumerable<Dto.ArticleDto> GetWebList_Menu()
        {
            return context.ArticleRepository.GetAll().Where(e => 
                e.ArticleParentId == null && 
                e.Active == true &&
                e.Schema.IsPage
                ).ProjectTo<Dto.ArticleDto>();
        }

        //public IEnumerable<Dto.ArticleDto> GetWebList_Section(int SectionId)
        //{
        //    var lSchema=context.SchemaRepository.GetAll().Where(e=>e.SectionId==2).Select(e=>e.Id);
        //    return context.ArticleRepository.GetAll().Where(e => e.ArticleParentId == null && e.Active == true && lSchema.Contains(e.SchemaId)).ProjectTo<Dto.ArticleDto>();
        //}

        public IEnumerable<Dto.ArticleDto> GetList_Schema(int SchemaId)
        {
            return context.ArticleRepository.Find(e => e.SchemaId == SchemaId).ProjectTo<Dto.ArticleDto>();
        }

        public Dto.ArticleDto GetItem(int Id)
        {
            //return eventos.FirstOrDefault(e => e.EventoId == id);
            return context
                .ArticleRepository.Find(e => e.Id == Id)
                .ProjectTo<ArticleDto>().FirstOrDefault();;
        }

        public void Add(ArticleDto request)
        {
            context.ArticleRepository.Add(Mapper.Map<ArticleDto, CmsArticle>(request));
            context.Commit();
        }

        public void Edit(ArticleDto request)
        {
            context.ArticleRepository.Update(Mapper.Map<ArticleDto, CmsArticle>(request));
            context.Commit();
        }

        public void Delete(int Id)
        {
            var post = context
                .ArticleRepository
                .Find(e => e.Id == Id).FirstOrDefault();

            context.ArticleRepository.Delete(post);
            context.Commit();
        }

    }


}
