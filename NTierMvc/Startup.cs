using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NTierMvc.Startup))]
namespace NTierMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
