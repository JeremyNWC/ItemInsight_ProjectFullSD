using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemInsight.Shared.Domain;
using ItemInsight.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItemInsight.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
            new ApplicationUser
                {
                    Id = "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                    Email = "consumer@gmail.com",
                    NormalizedEmail = "CONSUMER@GMAIL.COM",
                    FirstName = "Consumer",
                    LastName = "User",
                    UserName = "consumer@gmail.com",
                    NormalizedUserName = "CONSUMER@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2")
                },
             new ApplicationUser
                {
                     Id = "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                     Email = "producer@gmail.com",
                     NormalizedEmail = "PRODUCER@GMAIL.COM",
                     FirstName = "Producer",
                     LastName = "User",
                     UserName = "producer@gmail.com",
                     NormalizedUserName = "PRODUCER@GMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "P@ssword3")
                }
            );
        }
    }
}
