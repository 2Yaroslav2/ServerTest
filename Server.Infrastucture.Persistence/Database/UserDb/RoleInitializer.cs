using Microsoft.AspNetCore.Identity;
using Server.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server.Infrastucture.Persistence.Database.UserDb
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminName = "admin";
            string userName = "user04";
            string adminEmail = "admin@gmail.com";
            string userEmail = "user04@gmail.com";
            string password = "Test1234";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminName };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
            if (await userManager.FindByEmailAsync(userEmail) == null)
            {
                User user = new User { Email = userEmail, UserName = userName };
                IdentityResult result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "user");
                }
            }
        }
    }
}
