using Domain.Entities.DigitalAccount;
using Infraestructure.Database.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Infraestructure.Repositories
{
    public class DigitalAccountRepository : BaseRepository<DigitalAccount>
    {
        private readonly PostgreSQLDBContext _context;
        private readonly DbSet<DigitalAccount> _dbSet;

        public DigitalAccountRepository(PostgreSQLDBContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<DigitalAccount>();
        }
    }
}
