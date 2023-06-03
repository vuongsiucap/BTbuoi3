using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTbuoi3.Startup))]
namespace BTbuoi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
