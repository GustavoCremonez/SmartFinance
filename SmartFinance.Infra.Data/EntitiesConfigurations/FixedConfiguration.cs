using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Infra.Data.EntitiesConfigurations
{
    public class FixedConfiguration : IEntityTypeConfiguration<Fixed>
    {
        public void Configure(EntityTypeBuilder<Fixed> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description).HasColumnType("varchar").HasMaxLength(300).IsRequired();

            builder.HasIndex(x => x.NextDueDate);
            builder.HasIndex(x => x.AccountBankId);
        }
    }
}