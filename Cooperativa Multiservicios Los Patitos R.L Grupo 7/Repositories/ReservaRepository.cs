using System.Collections.Generic;
using System.Linq;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data;
//uno de los errores
//using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Data;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AppDbContext _context;

        public ReservaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Reservas> GetAll() =>
            _context.Reservas.ToList();

        public IEnumerable<Reservas> GetByServicio(int idServicio) =>
            _context.Reservas.Where(r => r.IdServicio == idServicio).ToList();

        public Reservas GetById(int id) =>
            _context.Reservas.FirstOrDefault(r => r.Id == id);

        public void Add(Reservas reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }
    }
}