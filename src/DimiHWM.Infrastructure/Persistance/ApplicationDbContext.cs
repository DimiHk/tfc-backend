using DimiHWM.Domain.Entities;
using DimiHWM.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DimiHWM.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            IdentityDbContextModelBuilderExtensions.ConfigureIdentitys(modelBuilder);
        }
    }
}