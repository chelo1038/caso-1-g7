using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models.Servicios> Servicios { get; set; } = default!;
    }
}
