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
                    ProductImage = "images/aboutus.jpg",
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
                    ProductImage = "images/aboutus1.jpg",
                    ProducerId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                    new Product
                    {
                        Id = 3,
                        Name = "Sofaz",
                        Category = "Furniture",
                        Cost = 99.9,
                        ProductImage = "images/homepage.jpg",
                        ProducerId = 3,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                    }
            );
        }
    }
}