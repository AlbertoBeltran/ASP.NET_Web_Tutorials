using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevinsTest.Startup))]
namespace DevinsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
