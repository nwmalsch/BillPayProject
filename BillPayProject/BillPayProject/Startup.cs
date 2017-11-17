using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillPayProject.Startup))]
namespace BillPayProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
