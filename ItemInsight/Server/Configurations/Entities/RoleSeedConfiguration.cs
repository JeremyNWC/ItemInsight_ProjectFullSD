using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ItemInsight.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    Name = "Staff",
                    NormalizedName = "STAFF",
                },
                new IdentityRole
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    Name = "Consumer",
                    NormalizedName = "CONSUMER",
                },
                new IdentityRole
                {
                    Id = "34ccd5d1-3c2e-4309-960d-9df1e2533017",
                    Name = "Producer",
                    NormalizedName = "PRODUCER",
                }
            );
        }
    }
}
