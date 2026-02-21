using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data
{
    public class Cooperativa_Multiservicios_Los_Patitos_RL_Grupo_7Context : DbContext
    {
        public Cooperativa_Multiservicios_Los_Patitos_RL_Grupo_7Context (DbContextOptions<Cooperativa_Multiservicios_Los_Patitos_RL_Grupo_7Context> options)
            : base(options)
        {
        }

        public DbSet<Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models.Servicio> Servicio { get; set; } = default!;
    }
}
