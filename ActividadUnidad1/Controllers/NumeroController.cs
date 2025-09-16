using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Signo()
        {
            int numero = 0;
            String resultado;

            if (numero > 0)
            {
               resultado = "El numero es positivo: ";
            }
            else
            {
               resultado = "El numero es negativo: ";
            }
            ViewBag.Signo= resultado;
            return View();
        }
    }
}
