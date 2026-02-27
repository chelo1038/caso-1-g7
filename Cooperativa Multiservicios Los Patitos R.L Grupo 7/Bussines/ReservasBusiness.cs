using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public class ReservasBusiness
    {
        private readonly IReservaRepository _repository;

        public ReservasBusiness(IReservaRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Reservas> GetAllReservas()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Reservas> GetReservasByServicio(int idServicio)
        {
            return _repository.GetByServicio(idServicio);
        }

        public Reservas GetReservaById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddReserva(Reservas reserva)
        {
            _repository.Add(reserva);
        }
    }
}