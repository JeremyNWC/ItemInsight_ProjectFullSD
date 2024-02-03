using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

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
                  Name = "JohnSmith",
                  ContactNo = "81234567",
                  Email = "smithies@gmail.com",
                  Password = "Jeremy"
              }
            );
        }
    }
}
