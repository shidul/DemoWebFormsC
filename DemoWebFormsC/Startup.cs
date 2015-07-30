using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebFormsC.Startup))]
namespace DemoWebFormsC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
