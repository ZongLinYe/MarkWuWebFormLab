using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkWuWEbFormLabDay21Server.Execute.Startup))]
namespace MarkWuWEbFormLabDay21Server.Execute
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
