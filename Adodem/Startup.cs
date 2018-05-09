using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adodem.Startup))]
namespace Adodem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
