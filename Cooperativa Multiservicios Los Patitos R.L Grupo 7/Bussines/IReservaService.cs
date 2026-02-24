using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public interface IReservaService
    {
        Reservas GetById(int id);
        IEnumerable<Reservas> GetAll();
        IEnumerable<Reservas> GetByServicio(int idServicio);
        void Crear(Reservas reserva);
    }
}