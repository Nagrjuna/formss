using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(registration_validation.Startup))]
namespace registration_validation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
