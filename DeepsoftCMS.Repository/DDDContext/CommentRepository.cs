using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class CommentRepository : GenericRepository<EFCMSRepository, Comment>
    {
        public CommentRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
