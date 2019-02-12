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
    public class ServiceSchema
    {
        private ICMSRepository context;

        public ServiceSchema()
        {
            context = new EFCMSRepository();
        }

        public IEnumerable<Dto.SchemaDto> GetList(Nullable<int> SchemaParentId)
        {
            return context.SchemaRepository
                .Find(e => e.SchemaParentId==SchemaParentId)
                .ProjectTo<Dto.SchemaDto>();
        }

        public Dto.SchemaDto GetItem(int Id)
        {
            return context
                .SchemaRepository.Find(e => e.Id == Id)
                .ProjectTo<SchemaDto>().FirstOrDefault();
        }

        public void Add(SchemaDto request)
        {
            context.SchemaRepository.Add(Mapper.Map<SchemaDto, CmsSchema>(request));
            context.Commit();
        }

        public void Edit(SchemaDto request)
        {
            context.SchemaRepository.Update(Mapper.Map<SchemaDto, CmsSchema>(request));
            context.Commit();
        }

        public void Delete(int Id)
        {
            var post = context
                .SchemaRepository
                .Find(e => e.Id == Id).FirstOrDefault();

            context.SchemaRepository.Delete(post);
            context.Commit();
        }

    }


}
