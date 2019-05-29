using Microsoft.EntityFrameworkCore;

namespace MANYdigitalHeroes.Models
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options) : base(options)
            {
            }

            public DbSet<Hero> Hero { get; set; }
    }
}
