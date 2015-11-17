using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BRS.WebUI.Startup))]
namespace BRS.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
