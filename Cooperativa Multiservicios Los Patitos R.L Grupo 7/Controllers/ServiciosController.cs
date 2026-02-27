using Microsoft.AspNetCore.Mvc;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ServiciosBusiness _business;

        public ServiciosController(ServiciosBusiness business)
        {
            _business = business;
        }

        public IActionResult Index()
        {
            var lista = _business.GetAllServicios();
            return View(lista);
        }

        public IActionResult Details(int id)
        {
            var servicio = _business.GetServicioById(id);
            if (servicio == null)
                return NotFound();

            return View(servicio);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servicios servicio)
        {
            if (!ModelState.IsValid)
                return View(servicio);

            _business.AddServicio(servicio);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var servicio = _business.GetServicioById(id);
            if (servicio == null)
                return NotFound();

            return View(servicio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Servicios servicio)
        {
            if (!ModelState.IsValid)
                return View(servicio);

            _business.UpdateServicio(servicio);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var servicio = _business.GetServicioById(id);
            if (servicio == null)
                return NotFound();

            return View(servicio);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var servicio = _business.GetServicioById(id);
            if (servicio != null)
            {
                servicio.Estado = false; // Baja lógica
                _business.UpdateServicio(servicio);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}