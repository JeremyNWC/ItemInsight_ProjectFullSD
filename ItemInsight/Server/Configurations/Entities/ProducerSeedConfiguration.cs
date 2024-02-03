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
                    ContactNo = "81079182",
                    Email = "jay@gmail.com",
                    Password = "jay",
                },

                new Producer
                {
                    Id = 2,
                    Name = "Nicole",
                    ContactNo = "99283749",
                    Email = "nicole@gmail.com",
                    Password = "nicole",
                },
                 new Producer
                 {
                     Id = 3,
                     Name = "Nicola",
                     ContactNo = "99283749",
                     Email = "nicole@gmail.com",
                     Password = "nicola"
                 }

            );
        }
    }
}
