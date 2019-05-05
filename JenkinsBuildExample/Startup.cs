using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsBuildExample.Startup))]
namespace JenkinsBuildExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
