using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(v2STEVENService.Startup))]

namespace v2STEVENService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}