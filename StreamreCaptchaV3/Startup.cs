using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StreamreCaptchaV3.Startup))]
namespace StreamreCaptchaV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
