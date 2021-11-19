using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityMVC.Startup))]
namespace SecurityMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
