using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Happy_Hut.Startup))]
namespace Happy_Hut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
