using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class SchemaRepository : GenericRepository<EFCMSRepository, CmsSchema>
    {
        public SchemaRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
