using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotifyTestWeb.Startup))]
namespace NotifyTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
