using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Extensions
{
    public class UserRoleDataSeedExtension
    {
        public static void SeedUser(ModelBuilder modelBuilder)
        {

            IdentityRole<int> appRole = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString() //bu ifade sisteminizin yeni bir Guid yaratmasını saglar
            };

            modelBuilder.Entity<IdentityRole<int>>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            AppUser user = new()
            {
                Id = 1,
                UserName = "anilumut",
                Email = "anilumuterdogan@gmail.com",
                NormalizedEmail = "ANILUMUTERDOGAN@GMAIL.COM",
                NormalizedUserName = "ANILUMUT",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "anil123")
            };

            modelBuilder.Entity<AppUser>().HasData(user);

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = appRole.Id,
                UserId = user.Id
            });



        }
    }
}
