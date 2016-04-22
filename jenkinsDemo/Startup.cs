using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkinsDemo.Startup))]
namespace jenkinsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
