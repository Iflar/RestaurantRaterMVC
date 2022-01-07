using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantRaterMVC.Startup))]
namespace ResturantRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
