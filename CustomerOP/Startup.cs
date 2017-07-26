using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerOP.Startup))]
namespace CustomerOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
