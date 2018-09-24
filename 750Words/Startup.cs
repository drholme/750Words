using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_750Words.Startup))]
namespace _750Words
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
