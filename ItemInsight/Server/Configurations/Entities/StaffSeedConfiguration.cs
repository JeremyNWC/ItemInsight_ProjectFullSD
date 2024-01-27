using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemInsight.Shared.Domain;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItemInsight.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "Jeremy",
                    ContactNo = "77164913",
                    Email = "jeremyng@gmail.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",

                },
                new Staff
                {
                    Id = 2,
                    Name = "Yan",
                    ContactNo = "73775752",
                    Email = "yanteo@gmail.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                }
            );
        }
    }
}
