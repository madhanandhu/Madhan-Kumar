using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(madhan2.Startup))]
namespace madhan2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
