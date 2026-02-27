using System.Collections.Generic;
using System.Linq;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;
//error
//using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Data;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly AppDbContext _context;

        public ServicioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Servicios> GetAll() =>
            _context.Servicios.ToList();

        public IEnumerable<Servicios> GetActivos() =>
            _context.Servicios.Where(s => s.Estado).ToList();

        public Servicios GetById(int id) =>
            _context.Servicios.FirstOrDefault(s => s.Id == id);

        public void Add(Servicios servicio)
        {
            _context.Servicios.Add(servicio);
            _context.SaveChanges();
        }

        public void Update(Servicios servicio)
        {
            _context.Servicios.Update(servicio);
            _context.SaveChanges();
        }
    }
}