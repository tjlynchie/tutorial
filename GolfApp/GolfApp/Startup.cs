using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfApp.Startup))]
namespace GolfApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
