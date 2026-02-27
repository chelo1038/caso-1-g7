using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public class ServiciosBusiness
    {
        private readonly IServicioRepository _repository;

        public ServiciosBusiness(IServicioRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Servicios> GetAllServicios()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Servicios> GetServiciosActivos()
        {
            return _repository.GetActivos();
        }

        public Servicios GetServicioById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddServicio(Servicios servicio)
        {
            _repository.Add(servicio);
        }

        public void UpdateServicio(Servicios servicio)
        {
            _repository.Update(servicio);
        }
    }
}