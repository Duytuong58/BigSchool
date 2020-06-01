using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaoBao.Startup))]
namespace BaoBao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
