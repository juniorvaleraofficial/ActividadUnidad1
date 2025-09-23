using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class SeguridadController : Controller
    {
        [HttpGet]
        public ActionResult ClaveFuerte()
        {
            ViewBag.Resultado = null;
            return View();
        }
    }
}
