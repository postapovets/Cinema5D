using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cinema5D.Startup))]
namespace Cinema5D
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
