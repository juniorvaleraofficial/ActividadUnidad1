using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double f = 0)
        {
            // Corrección: paréntesis correctos
            double c = (f - 32) / 1.8;

            // Guardar correctamente en el ViewBag
            double n = f;
            ViewBag.Fahrenheit = n;
            ViewBag.Celsius = c;

            return View();
        }
    }
}
