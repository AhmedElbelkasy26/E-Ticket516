using E_Ticket516.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket516.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<MovieImage> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=E-ticket516;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
