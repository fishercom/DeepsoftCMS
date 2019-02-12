using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class AdmProfileRepository : GenericRepository<EFCMSRepository, AdmProfile>
    {
        public AdmProfileRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
