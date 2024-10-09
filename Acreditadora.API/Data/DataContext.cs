using Acreditadora.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Acreditadora.API.Data
{
    public class DataContext:DbContext
    {
        public DbSet<University> Universities { get; set; }//clases a tablas
        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public DataContext(DbContextOptions<DataContext> options):base(options) //inyecciones de dependencia, addScoped, addTransient, addSingleton
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //solo puede existir una
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<University>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Major>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(x => x.Enrollment).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(y => y.Name).IsUnique();
            modelBuilder.Entity<Subject>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
//checar dependecy injection tecnica de desarrollo de software
//inversion de dependencias loC
