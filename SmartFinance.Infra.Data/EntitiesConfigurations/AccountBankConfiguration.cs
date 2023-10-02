using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Infra.Data.EntitiesConfigurations
{
    public class AccountBankConfiguration : IEntityTypeConfiguration<AccountBank>
    {
        public void Configure(EntityTypeBuilder<AccountBank> builder)
        {
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.BankName).HasColumnType("varchar").HasMaxLength(250);

            builder.HasMany(x => x.Transactions)
                .WithOne(x => x.AccountBank)
                .HasForeignKey(x => x.AccountBankId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Fixeds)
                .WithOne(x => x.AccountBank)
                .HasForeignKey(x => x.AccountBankId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}