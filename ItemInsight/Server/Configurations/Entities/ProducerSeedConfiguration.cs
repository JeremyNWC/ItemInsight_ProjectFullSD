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
                    Name = "Jay",
                    CompanyName = "JaysFashion",
                    ContactNo = "81079182",
                    Email = "jay@gmail.com",
                },

                new Producer
                {
                    Id = 2,
                    Name = "Nicole",
                    CompanyName = "NicFurn",
                    ContactNo = "99283749",
                    Email = "nicole@gmail.com"
                }
            );
        }
    }
}
