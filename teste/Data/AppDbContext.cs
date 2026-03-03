using Microsoft.EntityFrameworkCore;
using teste.Models; 

namespace teste.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Fatura> Faturas { get; set; }
    }
}