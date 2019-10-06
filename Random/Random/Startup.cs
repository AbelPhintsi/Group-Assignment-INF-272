using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Random.Startup))]
namespace Random
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
