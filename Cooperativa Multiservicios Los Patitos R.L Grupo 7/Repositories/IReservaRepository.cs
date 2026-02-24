using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories
{
    public interface IReservaRepository
    {
        IEnumerable<Reservas> GetAll();
        IEnumerable<Reservas> GetByServicio(int idServicio);
        Reservas GetById(int id);
        void Add(Reservas reserva);
    }
}