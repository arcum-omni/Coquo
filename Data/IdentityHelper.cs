using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coquo.Data
{
    internal static class IdentityHelper
    {
        internal static readonly string Admin = "Chef";
        internal static readonly string User = "Sous";

        internal static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            IdentityResult roleResult;

            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        /// <summary>
        /// Replaced lambda expression for services.AddDefaultIdentity<IdentityUser>() in Startup.
        /// Allows us to configure options to meet our requirements.
        /// </summary>
        /// <param name="options"></param>
        internal static void SetIdentityConfigOptions(IdentityOptions options)
        {
            options.SignIn.RequireConfirmedAccount = true;
            //options.Password.RequireDigit = true;
            //options.Password.RequiredLength = 6;
            //options.Password.RequireLowercase = true;
            //options.Password.RequireNonAlphanumeric = true;
            //options.Password.RequireUppercase = true;
        }
    }
}
