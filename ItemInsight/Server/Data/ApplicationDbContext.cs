using Duende.IdentityServer.EntityFramework.Options;
using ItemInsight.Server.Configurations.Entities;
using ItemInsight.Server.Models;
using ItemInsight.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ItemInsight.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new ProducerSeedConfiguration());
            builder.ApplyConfiguration(new ReviewSeedConfiguration());
            builder.ApplyConfiguration(new StaffSeedConfiguration());
            builder.ApplyConfiguration(new ConsumerSeedConfiguration());
            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new ListingSeedConfiguration());

        }

    }
}
