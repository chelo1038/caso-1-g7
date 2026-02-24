using System;
using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public class ServicioService : IServicioService
    {
        private readonly IServicioRepository _repo;

        public ServicioService(IServicioRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Servicios> GetAll() => _repo.GetAll();

        public IEnumerable<Servicios> GetActivos() => _repo.GetActivos();

        public Servicios GetById(int id) => _repo.GetById(id);

        public void Crear(Servicios servicio)
        {
            servicio.FechaDeRegistro = DateTime.Now;
            servicio.Estado = true;
            _repo.Add(servicio);
        }

        public void Editar(Servicios servicio)
        {
            servicio.FechaDeModificacion = DateTime.Now;
            _repo.Update(servicio);
        }
    }
}