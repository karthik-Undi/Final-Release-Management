using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReleaseFinal1.Startup))]
namespace ReleaseFinal1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
