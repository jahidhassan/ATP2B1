using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATP2B1.Startup))]
namespace ATP2B1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
