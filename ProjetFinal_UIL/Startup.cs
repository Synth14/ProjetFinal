using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetFinal_UIL.Startup))]
namespace ProjetFinal_UIL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
