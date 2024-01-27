using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItemInsight.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Dotted Dress",
                    Category = "Fashion",
                    Cost = 13.4,
                    ProducerId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    Name = "Sofa",
                    Category = "Furniture",
                    Cost = 99.9,
                    ProducerId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    Name = "Table",
                    Category = "Furniture",
                    Cost = 15,
                    ProducerId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                }
            );
        }
    }
}