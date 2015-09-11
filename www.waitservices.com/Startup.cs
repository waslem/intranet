using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(www.waitservices.com.Startup))]
namespace www.waitservices.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
