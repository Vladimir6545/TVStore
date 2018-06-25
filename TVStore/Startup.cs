using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TVStore.Helpers;
using TVStore.Models;

[assembly: OwinStartupAttribute(typeof(TVStore.Startup))]
namespace TVStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(ApplicationDbContext.Create()
                ));

            var UserManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(ApplicationDbContext.Create()
                ));

            // Admin Role and creating a default Admin User     
            if (!roleManager.RoleExists("Seller"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Seller";
                roleManager.Create(role);
                //The man
                var user = new ApplicationUser();
                user.UserName = "SuperHero";
                user.Email = "example@gmail.com";

                string userPWD = "123";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Seller");

                }
            }

            // creating Creating Manager role     
            if (!roleManager.RoleExists("User"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "User";
                roleManager.Create(role);
            }
        }
    }
}
