using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsonParserApp.Startup))]
namespace JsonParserApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
