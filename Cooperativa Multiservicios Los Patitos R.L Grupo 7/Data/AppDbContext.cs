using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Microsoft.EntityFrameworkCore;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Servicios> Servicios_G7 { get; set; }
        public DbSet<Reservas> Reservas_G7 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Servicios>().ToTable("SERVICIOS_G7");
            modelBuilder.Entity<Reservas>().ToTable("RESERVAS_G7");

            modelBuilder.Entity<Reservas>()
                .HasOne(r => r.Servicio)
                .WithMany(s => s.Reservas)
                .HasForeignKey(r => r.IdServicio)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}