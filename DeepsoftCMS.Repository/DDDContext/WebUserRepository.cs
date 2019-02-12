using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class WebUserRepository : GenericRepository<EFCMSRepository, WebUser>
    {
        public WebUserRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
