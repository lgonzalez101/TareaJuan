using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea1_CRUD.Startup))]
namespace Tarea1_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
