using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HearingInterviewTest.Startup))]
namespace HearingInterviewTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
