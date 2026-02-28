using ApiSolo.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.structure
{
    public class ConectionContext : DbContext
    {
        public DbSet<Book> book { get; set; }
        public ConectionContext(DbContextOptions<ConectionContext> options) : base(options)
            {
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432;Database=Library;Username=postgres;Password=postgres");
        }
    }
}
