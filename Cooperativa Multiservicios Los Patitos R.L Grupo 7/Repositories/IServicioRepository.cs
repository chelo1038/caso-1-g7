using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories
{
    public interface IServicioRepository
    {
        IEnumerable<Servicios> GetAll();
        IEnumerable<Servicios> GetActivos();
        Servicios GetById(int id);
        void Add(Servicios servicio);
        void Update(Servicios servicio);
    }
}