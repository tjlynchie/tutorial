using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppointmentCalendar.Startup))]
namespace AppointmentCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
