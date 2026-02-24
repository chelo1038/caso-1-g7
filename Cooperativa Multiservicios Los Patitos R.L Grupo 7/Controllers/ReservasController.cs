using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class ReservasController : Controller
    {
        private readonly IReservaService _reservaService;
        private readonly IServicioService _servicioService;

        public ReservasController(IReservaService reservaService, IServicioService servicioService)
        {
            _reservaService = reservaService;
            _servicioService = servicioService;
        }

        public IActionResult ServiciosDisponibles()
        {
            var servicios = _servicioService.GetActivos();
            return View(servicios);
        }

        public IActionResult Create(int idServicio)
        {
            var servicio = _servicioService.GetById(idServicio);
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

            _reservaService.Crear(model);
            return RedirectToAction("Confirmacion");
        }

        public IActionResult Buscar(int idReserva)
        {
            var reserva = _reservaService.GetById(idReserva);

            if (reserva == null)
            {
                ViewBag.Mensaje = "Estimado asociado, no se ha encontrado la reserva, favor realizar una nueva.";
                return View("NoEncontrada");
            }

            return View("DetalleReserva", reserva);
        }
    }
}