using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(STDemo.Startup))]
namespace STDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
