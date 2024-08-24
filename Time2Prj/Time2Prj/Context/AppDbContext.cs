using Microsoft.EntityFrameworkCore;
using Time2Prj.Models;

namespace Time2Prj.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Time> Times { get; set; }

    }
}
