using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthyANDTasty.Startup))]
namespace HealthyANDTasty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
