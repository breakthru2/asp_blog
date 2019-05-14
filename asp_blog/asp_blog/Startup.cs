using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_blog.Startup))]
namespace asp_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
