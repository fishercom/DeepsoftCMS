using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class AdmMenuRepository : GenericRepository<EFCMSRepository, AdmMenu>
    {
        public AdmMenuRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
