using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Infra.Data.EntitiesConfigurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.TransactionType).HasColumnType("varchar").HasMaxLength(120);
            builder.Property(x => x.Description).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}