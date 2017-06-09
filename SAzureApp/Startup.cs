using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAzureApp.Startup))]
namespace SAzureApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
