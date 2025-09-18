using Microsoft.AspNetCore.Mvc;
using System;

namespace ActividadUnidad1.Controllers
{
    [Route("[controller]")] // => "Operaciones"
    public class PrimoController : Controller
    {
        private static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;
            int limite = (int)Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
                if (n % i == 0) return false;
            return true;
        }

        //Operaciones/Primo/7  (n debe ser entero)
        [HttpGet("Primo/{n:int}")]
        public IActionResult Verificar(int n)
        {
            ViewBag.N = n;
            ViewBag.EsPrimo = EsPrimo(n);
            return View();
        }
    }
}
