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

        [HttpPost]
        public ActionResult ClaveFuerte(string clave) 
        {
            if (string.IsNullOrEmpty(clave))
            {
                ViewBag.Resultado = "Ingresa una contraseña para evaluar.";
                ViewBag.EsSegura = false;
                return View();
            }

            bool tieneMayus = false;
            bool tieneMinus = false;
            bool tieneNumero = false;
        }

    }
}
