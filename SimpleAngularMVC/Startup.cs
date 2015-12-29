using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAngularMVC.Startup))]
namespace SimpleAngularMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
