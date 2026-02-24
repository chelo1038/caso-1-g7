using System.Collections.Generic;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines
{
    public interface IServicioService
    {
        IEnumerable<Servicios> GetAll();
        IEnumerable<Servicios> GetActivos();
        Servicios GetById(int id);
        void Crear(Servicios servicio);
        void Editar(Servicios servicio);
    }
}