using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Saludo()
        {
            return View();
        }
    }
}
