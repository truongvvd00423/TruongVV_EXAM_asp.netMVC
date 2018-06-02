using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.NET_Subject.Startup))]
namespace MVC.NET_Subject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
