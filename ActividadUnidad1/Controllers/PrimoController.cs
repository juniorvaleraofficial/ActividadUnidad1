using Microsoft.AspNetCore.Mvc;
using System;

namespace ActividadUnidad1.Controllers
{
    public class PrimoController : Controller
    {
        // --- Lógica ---
        private bool EsPrimo(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;

            int limite = (int)Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
                if (n % i == 0) return false;

            return true;
        }

        //Operaciones/Primo?n=7 
        [HttpGet]
        public IActionResult Verificar(int? n)
        {
            if (n.HasValue)
            {
                ViewBag.N = n.Value;
                ViewBag.EsPrimo = EsPrimo(n.Value);
            }
            return View();
        }

        //Operaciones/Primo/7
        [HttpGet("Operaciones/Primo/{n:int?}")]
        public IActionResult PrimoConRuta(int? n) => Verificar(n);
    }
}
