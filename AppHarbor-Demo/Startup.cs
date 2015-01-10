using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppHarbor_Demo.Startup))]
namespace AppHarbor_Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
