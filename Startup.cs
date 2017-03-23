using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital_Management_Database.Startup))]
namespace Hospital_Management_Database
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
