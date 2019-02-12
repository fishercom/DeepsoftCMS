using LayqaMVC.Repository.Entity;

namespace LayqaMVC.Repository.DDDContext
{
    public class TemplateRepository : GenericRepository<EFLayqaMVCRepository, CmsTemplate>
    {
        public TemplateRepository(EFLayqaMVCRepository context)
            : base(context)
        {
        }
    }

}
