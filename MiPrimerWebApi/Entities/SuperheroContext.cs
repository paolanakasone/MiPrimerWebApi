using Microsoft.EntityFrameworkCore;

namespace MiPrimerWebApi.Entities
{
    public class SuperheroContext : DbContext
    {
        public SuperheroContext(DbContextOptions<SuperheroContext> options) : base(options)
        {
        }

        public DbSet<Superhero> Superhero { get; set; }
    }
}

