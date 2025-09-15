using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Saludo()
        {
            ViewBag.Nombre = "Junior Alexis";
            ViewBag.Apellido = "Valera Rijo";
            ViewBag.Matricula = "MT-2023-00518";
            return View();
        }
    }
}
