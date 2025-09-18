using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroTablaController : Controller
    {
        [HttpGet("NumeroTabla/Tabla/{a:int}")]
        public IActionResult Tabla(int a = 0)
        {
            int resultado = 0;
            for (int i = 1; i <= 10; i++)
            {
                resultado = a * i;
            }
            ViewBag.resultado = resultado;
            return View();
        }
    }
}
