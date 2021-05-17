using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurfersLand.Startup))]
namespace SurfersLand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
