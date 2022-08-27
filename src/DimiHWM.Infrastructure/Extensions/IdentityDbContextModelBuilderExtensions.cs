using DimiHWM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DimiHWM.Infrastructure.Extensions
{
    public static class IdentityDbContextModelBuilderExtensions
    {
        public static void ConfigureIdentitys(this ModelBuilder builder)
        {
            builder.ConfigureTeacherIdentity();
        }

        public static ModelBuilder ConfigureTeacherIdentity(this ModelBuilder builder)
        {
            builder.Entity<Teacher>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");

            builder.Entity<Teacher>()
                .Property(x => x.Name)
                .HasMaxLength(255);

            builder.Entity<Teacher>()
                .Property(x => x.Password)
                .HasMaxLength(256);

            builder.Entity<Teacher>()
                .Property(x => x.NIF)
                .IsRequired()
                .HasMaxLength(9);

            builder.Entity<Teacher>()
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(254);

            builder.Entity<Teacher>()
                .Property(x => x.PhoneNumber)
                .HasMaxLength(15);

            return builder;
        }
    }
}