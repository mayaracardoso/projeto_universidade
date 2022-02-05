using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoUniversidade.Startup))]
namespace ProjetoUniversidade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
