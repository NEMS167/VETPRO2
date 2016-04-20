using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VETPRO2.Startup))]
namespace VETPRO2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
