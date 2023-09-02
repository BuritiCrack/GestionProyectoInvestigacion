using Microsoft.EntityFrameworkCore;
using Proyecto2.Shared.Entities;

namespace Proyecto2.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProyectoDeInvestigacion> ProyectoDeInvestigacions { get; set; }
        public DbSet<Investigador> Investigadors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProyectoDeInvestigacion>().HasIndex(c => c.Id).IsUnique();

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Investigador>().HasIndex(c => c.Id).IsUnique();

        }
    }
}
