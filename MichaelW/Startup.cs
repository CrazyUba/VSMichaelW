using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MichaelW.Startup))]
namespace MichaelW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
