using System;
using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _repo;
        private readonly IServicioRepository _servicioRepo;

        public ReservaService(IReservaRepository repo, IServicioRepository servicioRepo)
        {
            _repo = repo;
            _servicioRepo = servicioRepo;
        }

        public Reservas GetById(int id) => _repo.GetById(id);

        public IEnumerable<Reservas> GetAll() => _repo.GetAll();

        public IEnumerable<Reservas> GetByServicio(int idServicio) =>
            _repo.GetByServicio(idServicio);

        public void Crear(Reservas reserva)
        {
            var servicio = _servicioRepo.GetById(reserva.IdServicio);

            if (servicio == null || !servicio.Estado)
                throw new Exception("El servicio no está disponible.");

            reserva.MontoTotal = (servicio.Monto * servicio.IVA) + servicio.Monto;
            reserva.FechaDeRegistro = DateTime.Now;

            _repo.Add(reserva);
        }
    }
}