using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Localization.Startup))]
namespace Localization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
