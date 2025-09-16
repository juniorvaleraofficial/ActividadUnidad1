using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Signo()
        {
            int numero = -1;
            string resultado; 

            if (numero > 0)
            {
                resultado = "El numero es positivo: ";
            }
            else if (numero < 0)
            {
                resultado = "El numero es negativo: ";
            }
            else{
                resultado = "El numero neutro: ";
            }
            ViewBag.resultado = resultado;
            return View();
        }
    }
}
