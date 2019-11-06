using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public static class AppDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser()
            {
                UserName = "test",
                Email = "test@test.com"
            };
            await userManager.CreateAsync(defaultUser, "test");
        }
    }
}
