using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class ArticleRepository : GenericRepository<EFCMSRepository, CmsArticle>
    {
        public ArticleRepository(EFCMSRepository context)
            : base(context)
        {
        }
    }

}
