using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularWithMVCSample.Startup))]
namespace AngularWithMVCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
