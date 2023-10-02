using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Infra.Data.EntitiesConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(250).IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar").HasMaxLength(120).IsRequired();
            builder.Property(x => x.Birthdate).HasColumnType("date").IsRequired();
            builder.Property(x => x.Phone_number).HasColumnType("varchar").HasMaxLength(40).IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();

            builder.HasMany(x => x.BankAccounts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}