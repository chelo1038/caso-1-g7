using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Microsoft.EntityFrameworkCore;

namespace Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Tablas del sistema
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Reservas> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relación: Un Servicio tiene muchas Reservas
            modelBuilder.Entity<Reservas>()
                .HasOne(r => r.Servicio)
                .WithMany(s => s.Reservas)
                .HasForeignKey(r => r.IdServicio)
                .OnDelete(DeleteBehavior.Restrict);
            // Evita borrar reservas si se borra un servicio
        }
    }
}

