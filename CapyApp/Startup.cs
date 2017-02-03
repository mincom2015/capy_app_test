using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapyApp.Startup))]
namespace CapyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
