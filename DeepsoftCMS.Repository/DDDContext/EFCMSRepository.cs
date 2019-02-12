using System.Data.Entity;
using System.Linq;
using DeepsoftCMS.Repository.Entity;

namespace DeepsoftCMS.Repository.DDDContext
{
    public class EFCMSRepository : DbContext, ICMSRepository
    {
        private readonly AdmProfileRepository _AdmProfileRepo;
        private readonly AdmUserRepository _AdmUserRepo;
        private readonly AdmMenuRepository _AdmMenuRepo;
        private readonly WebUserRepository _WebUserRepo;

        //private readonly SectionRepository _SectionRepo;
        private readonly CommentRepository _CommentRepo;
        private readonly SchemaRepository _SchemaRepo;
        private readonly ArticleRepository _ArticleRepo;
        private readonly PostRepository _PostRepo;

        public DbSet<AdmProfile> AdmProfilees { get; set; }
        public DbSet<AdmUser> AdmUser { get; set; }
        public DbSet<AdmMenu> AdmMenus { get; set; }
        public DbSet<WebUser> WebUser { get; set; }

        //public DbSet<Section> Sections { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CmsSchema> Schemas { get; set; }
        public DbSet<CmsArticle> Articles { get; set; }

        public EFCMSRepository()
            : base("name=DeepsoftCMS")
        {
            _AdmProfileRepo = new AdmProfileRepository(this);
            _AdmUserRepo = new AdmUserRepository(this);
            _AdmMenuRepo = new AdmMenuRepository(this);
            _WebUserRepo = new WebUserRepository(this);

            //_SectionRepo = new SectionRepository(this);
            _CommentRepo = new CommentRepository(this);
            _SchemaRepo = new SchemaRepository(this);
            _ArticleRepo = new ArticleRepository(this);
            _PostRepo = new PostRepository(this);
        }

        #region IUnitOfWork Implementation



        public void Commit()
        {
            this.SaveChanges();
        }

        #endregion

        public IGenericRepository<AdmProfile> AdmProfileRepository
        {
            get { return _AdmProfileRepo; }
        }

        public IGenericRepository<AdmUser> AdmUserRepository
        {
            get { return _AdmUserRepo; }
        }

        public IGenericRepository<WebUser> WebUserRepository
        {
            get { return _WebUserRepo; }
        }

        /*
        public IGenericRepository<Section> SectionRepository
        {
            get { return _SectionRepo; }
        }
        */

        public IGenericRepository<AdmMenu> AdmMenuRepository
        {
            get { return _AdmMenuRepo; }
        }

        public IGenericRepository<Comment> CommentRepository
        {
            get { return _CommentRepo; }
        }

        public IGenericRepository<CmsSchema> SchemaRepository
        {
            get { return _SchemaRepo; }
        }
        public IGenericRepository<CmsArticle> ArticleRepository
        {
            get { return _ArticleRepo; }
        }

        public IGenericRepository<Post> PostRepository
        {
            get { return _PostRepo; }
        }

    }

}
