using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroTablaController : Controller
    {
        public IActionResult Tabla(int id = 0) // ahora /NumeroTabla/Tabla/10 enlaza a id
        {
            var filas = new List<string>();
            for (int i = 1; i <= 10; i++)
                filas.Add($"{id} × {i} = {id * i}");

            ViewBag.Numero = id;
            ViewBag.Filas = filas;
            return View();
        }

    }
}
