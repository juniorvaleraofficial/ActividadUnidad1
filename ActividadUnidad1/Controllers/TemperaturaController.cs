using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double f = 0)
        {
            double c = (f - 32) / 1.8;
            double convertir = f;
            ViewBag.Fahrenheit = c;
            ViewBag.Convertir = convertir;
            return View();
        }
    }
}
