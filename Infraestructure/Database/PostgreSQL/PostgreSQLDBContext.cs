using Domain.Entities.DigitalAccount;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Database.PostgreSQL
{
    public class PostgreSQLDBContext : DbContext
    {
        public PostgreSQLDBContext(DbContextOptions<PostgreSQLDBContext> options) : base(options) { }

        public DbSet<DigitalAccount> DigitalAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}