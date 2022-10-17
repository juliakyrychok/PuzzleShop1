using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleShop.Core
{
    public static class PuzzleShopDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string MANAGER_ROLE_ID = Guid.NewGuid().ToString();
            string CUSTOMER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = MANAGER_ROLE_ID,
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                },
                new IdentityRole
                {
                    Id = CUSTOMER_ROLE_ID,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });

            string ADMIN_ID = Guid.NewGuid().ToString();
            string MANAGER_ID = Guid.NewGuid().ToString();
            string CUSTOMER_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@puzzleshop.com",
                Email = "admin@puzzleshop.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@puzzleshop.com".ToUpper(),
                NormalizedUserName = "admin@puzzleshop.com".ToUpper()
            };
            var manager = new User
            {
                Id = MANAGER_ID,
                UserName = "manager@puzzleshop.com",
                Email = "manager@puzzleshop.com",
                EmailConfirmed = true,
                NormalizedEmail = "manager@puzzleshop.com".ToUpper(),
                NormalizedUserName = "manager@puzzleshop.com".ToUpper()
            };
            var customer = new User
            {
                Id = CUSTOMER_ID,
                UserName = "customer@puzzleshop.com",
                Email = "customer@puzzleshop.com",
                EmailConfirmed = true,
                NormalizedEmail = "customer@puzzleshop.com".ToUpper(),
                NormalizedUserName = "customer@puzzleshop.com".ToUpper()
            };


            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "admin$Pass1");
            manager.PasswordHash = hasher.HashPassword(manager, "manager$Pass1");
            customer.PasswordHash = hasher.HashPassword(customer, "customer$Pass1");

            builder.Entity<User>().HasData(manager, customer, admin);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MANAGER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = CUSTOMER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MANAGER_ROLE_ID,
                    UserId = MANAGER_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = CUSTOMER_ROLE_ID,
                    UserId = MANAGER_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = CUSTOMER_ROLE_ID,
                    UserId = CUSTOMER_ID
                }
                );
        }
    }
}
