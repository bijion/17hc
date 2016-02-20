using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hongcheng.Startup))]
namespace hongcheng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
