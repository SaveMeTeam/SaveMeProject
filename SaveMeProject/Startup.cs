using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using SaveMeProject.Models;

[assembly: OwinStartupAttribute(typeof(SaveMeProject.Startup))]
namespace SaveMeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    

        }
}
