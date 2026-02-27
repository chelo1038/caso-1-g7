using System.Diagnostics;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}