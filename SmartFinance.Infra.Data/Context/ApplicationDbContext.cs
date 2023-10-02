using Microsoft.EntityFrameworkCore;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;

        public DbSet<AccountBank> BankAccounts { get; set; } = default!;

        public DbSet<Fixed> Fixeds { get; set; } = default!;

        public DbSet<Transaction> Transactions { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}