using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class AdmUserRepository : GenericRepository<EFCMSRepository, AdmUser>
    {
        public AdmUserRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
