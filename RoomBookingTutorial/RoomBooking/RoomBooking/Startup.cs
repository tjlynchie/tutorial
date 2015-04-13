using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomBooking.Startup))]
namespace RoomBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
