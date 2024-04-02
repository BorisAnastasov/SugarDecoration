﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models.Account;
using System.Collections.Generic;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(SeedUsers());
        }

        private static IEnumerable<ApplicationUser> SeedUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "1182e1d8-c799-413d-a9d3-c809966f5ed2",
                FirstName = "Boris",
                LastName = "Anastasov",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@abv.bd",
                NormalizedEmail = "ADMIN@ABV.bg",
            };
            user.PasswordHash =
                 hasher.HashPassword(user, "admin123.");

            users.Add(user);

             user = new ApplicationUser()
            {
                Id = "3b034442-ee41-4acb-92cb-374f72d60a59",
                FirstName = "Georgi",
                LastName = "Ivanov",
                UserName = "Goshe",
                NormalizedUserName = "GOSHE",
                Email = "g_ivanov@abv.bg",
                NormalizedEmail = "G_IVANOV@ABV.bg",
            };
            user.PasswordHash =
                 hasher.HashPassword(user, "guest123.");

            users.Add(user);

            return users;
        }
    }
}