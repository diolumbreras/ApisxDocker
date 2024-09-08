using Datadock;
using Microsoft.EntityFrameworkCore;

namespace DockxApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Cursos> Cursos { get; set; }
        //CREAR BASE DE DATOS EN SQL
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cursos>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}
