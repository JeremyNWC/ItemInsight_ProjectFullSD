using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemInsight.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItemInsight.Server.Configurations.Entities
{
    public class ListingSeedConfiguration : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.HasData(
                new Listing
                {
                    Id = 1,
                    Name = "Fashion",
                },

                new Listing
                {
                    Id = 2,
                    Name = "Furniture",
                },

                new Listing
                {
                    Id = 3,
                    Name = "Lifestyle"
                }
            );
        }
    }
}
