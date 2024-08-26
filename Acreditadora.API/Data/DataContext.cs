using Acreditadora.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Acreditadora.API.Data
{
    public class DataContext:DbContext
    {
        public DbSet<University> Universities { get; set; }

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //solo puede existir una
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<University>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
