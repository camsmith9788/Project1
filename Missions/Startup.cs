using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Missions.Startup))]
namespace Missions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
