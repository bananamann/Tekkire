using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tekkire.Startup))]
namespace Tekkire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
