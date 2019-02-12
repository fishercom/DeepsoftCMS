using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeepsoftCMS.Startup))]
namespace DeepsoftCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
