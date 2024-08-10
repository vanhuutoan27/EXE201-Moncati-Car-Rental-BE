using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Identity;

namespace MoncatiCar.Data
{
    public class DataSeeder
    {
        public async Task SeedAsync(MocatiContext context)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            var rootAdminRoleId = Guid.NewGuid();

            if (!context.Roles.Any(r => r.Name.Equals("Admin")))
            {
                await context.Roles.AddAsync(new AppRole()
                {
                    Id = rootAdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    DisplayName = "Quản trị viên"
                });
                await context.SaveChangesAsync();
            }

            if (!context.Users.Any())
            {
                var userId = Guid.NewGuid();
                var user = new AppUser()
                {
                    Id = userId,
                    FullName = "asd",
                    Email = "asd@gmail.com",
                    NormalizedEmail = "ASD@GMAIL.COM",
                    UserName = "asd",
                    NormalizedUserName = "ASD",
                    Address = "Cu Chi",
                    IsActive = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    LockoutEnabled = false,
                    CreatedAt = DateTime.Now,
                    EmailConfirmed = true,

                };
                user.PasswordHash = passwordHasher.HashPassword(user, "123As@");
                await context.Users.AddAsync(user);

                await context.UserRoles.AddAsync(new IdentityUserRole<Guid>()
                {
                    RoleId = rootAdminRoleId,
                    UserId = userId,
                });
                await context.SaveChangesAsync();
            }
        }
    }
}
