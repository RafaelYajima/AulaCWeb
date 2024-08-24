using Microsoft.EntityFrameworkCore;
using MoveisPrj.Models;

namespace MoveisPrj.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Movel> Moveis {get; set;}
    }
}
