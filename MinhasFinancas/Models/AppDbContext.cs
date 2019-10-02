using Microsoft.EntityFrameworkCore;

namespace MinhasFinancas.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<RelatorioDespesa> RelatorioDespesas { get; set; }

        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options)
        {

        }
    }
}
