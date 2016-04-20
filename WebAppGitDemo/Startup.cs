using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGitDemo.Startup))]
namespace WebAppGitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
