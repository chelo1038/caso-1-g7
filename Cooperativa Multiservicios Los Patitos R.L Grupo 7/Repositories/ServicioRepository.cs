using System.Collections.Generic;
using System.Linq;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Data;
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
            _context.Servicios_G7.ToList();

        public IEnumerable<Servicios> GetActivos() =>
            _context.Servicios_G7.Where(s => s.Estado).ToList();

        public Servicios GetById(int id) =>
            _context.Servicios_G7.FirstOrDefault(s => s.Id == id);

        public void Add(Servicios servicio)
        {
            _context.Servicios_G7.Add(servicio);
            _context.SaveChanges();
        }

        public void Update(Servicios servicio)
        {
            _context.Servicios_G7.Update(servicio);
            _context.SaveChanges();
        }
    }
}