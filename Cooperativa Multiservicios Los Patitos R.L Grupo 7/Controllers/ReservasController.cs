using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class ReservasController : Controller
    {
        private readonly ReservasBusiness _reservasBusiness;
        private readonly ServiciosBusiness _serviciosBusiness;

        public ReservasController(ReservasBusiness reservasBusiness, ServiciosBusiness serviciosBusiness)
        {
            _reservasBusiness = reservasBusiness;
            _serviciosBusiness = serviciosBusiness;
        }

        public IActionResult ServiciosDisponibles()
        {
            var servicios = _serviciosBusiness.GetServiciosActivos();
            return View(servicios);
        }

        public IActionResult Create(int idServicio)
        {
            var servicio = _serviciosBusiness.GetServicioById(idServicio);
            if (servicio == null || !servicio.Estado)
                return NotFound();

            ViewBag.Servicio = servicio;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservas model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _reservasBusiness.AddReserva(model);
            return RedirectToAction("Confirmacion");
        }

        public IActionResult Buscar(int idReserva)
        {
            var reserva = _reservasBusiness.GetReservaById(idReserva);

            if (reserva == null)
            {
                ViewBag.Mensaje = "Estimado asociado, no se ha encontrado la reserva, favor realizar una nueva.";
                return View("NoEncontrada");
            }

            return View("DetalleReserva", reserva);
        }
    }
}