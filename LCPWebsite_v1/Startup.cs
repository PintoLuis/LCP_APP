using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LCPWebsite_v1.Startup))]
namespace LCPWebsite_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
