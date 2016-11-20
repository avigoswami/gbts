using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(goswamibhatttailang.Startup))]
namespace goswamibhatttailang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
