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
                    ConsumerReview = "Good",
                    Category = "ABC",
                    Rating = 5,
                    CreatedBy = DateTime.Now,
                    UpdatedBy = DateTime.Now
                });
        }
    }
}