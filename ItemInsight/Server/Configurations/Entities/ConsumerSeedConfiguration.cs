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
    public class ConsumerSeedConfiguration : IEntityTypeConfiguration<Consumer>
    {
        public void Configure(EntityTypeBuilder<Consumer> builder)
        {
            builder.HasData(
               new Consumer
               {
                   Id = 1,
                   Name = "Aden",
                   ContactNo = "87538922",
                   Email = "adenGaming@gmail.com",
                   Password = "Aden",
               },
               new Consumer
               {
                   Id = 2,
                   Name = "Clare",
                   ContactNo = "92830481",
                   Email = "clare@gmail.com",
                   Password = "Clare"
               }
            );
        }
    }
}
