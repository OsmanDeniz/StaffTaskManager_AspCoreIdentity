using System.Threading.Tasks;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace Deniz.StaffTaskManager.WebUI
{
    public static class IdentitiyInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("osman");
            if (adminUser == null)
            {
                AppUser appUser = new AppUser
                {
                    Name = "osman",
                    Surname = "deniz",
                    UserName = "osman",
                    Email = "osmandeniz.ceng@gmail.com"
                };
                await userManager.CreateAsync(appUser, "osman");
                await userManager.AddToRoleAsync(appUser, "Admin");
            }
        }
    }
}
