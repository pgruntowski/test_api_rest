using Microsoft.EntityFrameworkCore;

namespace WebApp
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options)
            : base(options) { }

        public DbSet<Player> Players { get; set; }
    }
}
