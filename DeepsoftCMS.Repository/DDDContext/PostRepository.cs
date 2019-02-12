using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class PostRepository : GenericRepository<EFCMSRepository, Post>
    {
        public PostRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
