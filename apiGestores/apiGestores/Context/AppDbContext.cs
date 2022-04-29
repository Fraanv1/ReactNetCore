using apiGestores.Models;
using Microsoft.EntityFrameworkCore;

namespace apiGestores.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<GestoresBD> gestores_bd { get; set; }
    }
}
