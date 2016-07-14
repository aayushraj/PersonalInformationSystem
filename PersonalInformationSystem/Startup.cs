using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalInformationSystem.Startup))]
namespace PersonalInformationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
