using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ItemInsight.Server.Configurations.Entities
{
    public class ProducerSeedConfiguration : IEntityTypeConfiguration<Producer>
    {
        public void Configure(EntityTypeBuilder<Producer> builder)
        {
            builder.HasData(
                new Producer
                {
                    Id = 1,
                    Name = "Mike",
                    CompanyName = "MikeVogue",
                    ContactNo = "67894532",
                    Email = "MikeVogue@gmail.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Producer
                {
                    Id = 2,
                    Name = "John",
                    CompanyName = "JFurniture",
                    ContactNo = "61428973",
                    Email = "JFurniture@gmail.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                }
            );
        }
    }
}
