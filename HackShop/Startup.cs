using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackShop.Startup))]
namespace HackShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
