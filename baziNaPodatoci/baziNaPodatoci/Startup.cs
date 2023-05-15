using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baziNaPodatoci.Startup))]
namespace baziNaPodatoci
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
