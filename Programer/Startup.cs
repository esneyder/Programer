using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Programer.Startup))]
namespace Programer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
