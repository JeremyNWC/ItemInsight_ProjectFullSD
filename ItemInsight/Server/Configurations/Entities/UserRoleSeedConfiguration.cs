using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ItemInsight.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "f5eb6ea1-d9cc-40dd-be1a-829c3edf2069",
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "34ccd5d1-3c2e-4309-960d-9df1e2533017",
                     UserId = "2807eff2-b8a5-482d-bdb3-a2291dbc60a8",
                 }
            );
        }
    }
}
