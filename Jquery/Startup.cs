using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jquery.Startup))]
namespace Jquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
