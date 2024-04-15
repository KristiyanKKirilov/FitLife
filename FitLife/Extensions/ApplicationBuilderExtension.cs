using FitLife.Data.Models;
using Microsoft.AspNetCore.Identity;
using static FitLife.GlobalConstants.RoleConstants;

namespace Microsoft.AspNetCore.Builder
{
	public static class ApplicationBuilderExtension
	{
		public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
		{
			using var scope = app.ApplicationServices.CreateScope();
			var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Participant>>();
			var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			
			if(userManager != null &&
				roleManager != null &&
				await roleManager.RoleExistsAsync(AdminRole) == false)
			{
				var role = new IdentityRole(AdminRole);
				await roleManager.CreateAsync(role);

				var admin = await userManager.FindByEmailAsync(AdminEmail);

                if (admin != null)
                {
					await userManager.AddToRoleAsync(admin, role.Name);
                }
            }
		}
	}
}
