using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnergyApplication.Startup))]
namespace EnergyApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
