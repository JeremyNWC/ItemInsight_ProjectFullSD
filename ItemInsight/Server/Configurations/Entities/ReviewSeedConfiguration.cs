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
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {

            builder.HasData(
                new Review
                {
                    Id = 1,
                    ConsumerReview = "Wonderful product",
                    Category = "Fashion",
                    Rating = 5,
                    ProductId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Review
                {
                    Id = 2,
                    ConsumerReview = "Mediocre product",
                    Category = "Furniture",
                    Rating = 3.5,
                    ProductId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                      new Review
                      {
                          Id = 3,
                          ConsumerReview = "Mediocre product",
                          Category = "Furniture",
                          Rating = 3.5,
                          ProductId = 3,
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                      }
            );
        }
    }
}