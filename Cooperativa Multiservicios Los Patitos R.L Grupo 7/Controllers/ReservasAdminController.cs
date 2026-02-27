using Microsoft.AspNetCore.Mvc;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class ReservasAdminController : Controller
    {
        private readonly ReservasBusiness _business;

        public ReservasAdminController(ReservasBusiness business)
        {
            _business = business;
        }

        public IActionResult Index(int? idServicio)
        {
            var lista = idServicio == null
                ? _business.GetAllReservas()
                : _business.GetReservasByServicio(idServicio.Value);

            return View(lista);
        }
    }
}