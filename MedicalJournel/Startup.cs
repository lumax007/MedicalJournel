using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalJournel.Startup))]
namespace MedicalJournel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
