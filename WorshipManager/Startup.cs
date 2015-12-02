using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorshipManager.Startup))]
namespace WorshipManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
