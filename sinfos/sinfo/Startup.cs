using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sinfo.Startup))]
namespace sinfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
