using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Receptbank.Startup))]
namespace Receptbank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
