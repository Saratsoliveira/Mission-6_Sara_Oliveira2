using Microsoft.EntityFrameworkCore;

namespace Mission_6_Sara_Oliveira.Models
{
    public class FilmContext: DbContext

    {
        public FilmContext(DbContextOptions<FilmContext> options): base(options) { }

        public DbSet<Application> Applications { get; set; }
    }
}
