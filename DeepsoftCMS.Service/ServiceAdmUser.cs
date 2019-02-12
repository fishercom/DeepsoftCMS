using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using DeepsoftCMS.Repository.DDDContext;
using DeepsoftCMS.Repository.Entity;
using DeepsoftCMS.Service.Dto;

namespace DeepsoftCMS.Service
{
    public class ServiceAdmUser
    {
        private ICMSRepository context;

        public ServiceAdmUser()
        {
            context = new EFCMSRepository();
        }

        public IEnumerable<Dto.AdmUserDto> GetList()
        {
            return context.AdmUserRepository.GetAll().ProjectTo<Dto.AdmUserDto>();
        }

        public Dto.AdmUserDto GetItem(int Id)
        {
            var user = context
                .AdmUserRepository.Find(e => e.Id == Id)
                .ProjectTo<AdmUserDto>().Single();

            return user;
        }

        public Dto.AdmUserDto GetItem_Email(string email)
        {
            var user = context
                .AdmUserRepository.Find(e => e.Email == email)
                .ProjectTo<AdmUserDto>().Single();

            return user;
        }

        public void Add(AdmUserDto request)
        {
            context.AdmUserRepository.Add(Mapper.Map<AdmUserDto, AdmUser>(request));
            context.Commit();
        }

        public void Edit(AdmUserDto request)
        {
            context.
                AdmUserRepository.Update(Mapper.Map<AdmUserDto, AdmUser>(request));
            context.Commit();
        }

        public void Delete(int Id)
        {
            var User = context
                .AdmUserRepository
                .Find(e => e.Id == Id).FirstOrDefault();

            context
                .AdmUserRepository.Delete(User);
            context.Commit();
        }
    }


}
