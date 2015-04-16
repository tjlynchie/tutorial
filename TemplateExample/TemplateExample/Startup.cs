using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateExample.Startup))]
namespace TemplateExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
