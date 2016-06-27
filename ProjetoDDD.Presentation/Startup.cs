using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoDDD.Presentation.Startup))]
namespace ProjetoDDD.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
