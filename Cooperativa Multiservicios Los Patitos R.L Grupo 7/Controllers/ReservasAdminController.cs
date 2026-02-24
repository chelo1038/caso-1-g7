using Microsoft.AspNetCore.Mvc;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class ReservasAdminController : Controller
    {
        private readonly IReservaService _service;

        public ReservasAdminController(IReservaService service)
        {
            _service = service;
        }

        public IActionResult Index(int? idServicio)
        {
            var lista = idServicio == null
                ? _service.GetAll()
                : _service.GetByServicio(idServicio.Value);

            return View(lista);
        }
    }
}