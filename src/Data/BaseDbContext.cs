using C__VSCode.Models;
using Microsoft.EntityFrameworkCore;

namespace C__VSCode.Data
{
    public class BaseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<BankAccount>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
