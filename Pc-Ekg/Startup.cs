using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pc_Ekg.Startup))]
namespace Pc_Ekg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
