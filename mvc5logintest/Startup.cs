using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5logintest.Startup))]
namespace mvc5logintest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
