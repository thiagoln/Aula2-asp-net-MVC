using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAula2.Startup))]
namespace WebAula2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
