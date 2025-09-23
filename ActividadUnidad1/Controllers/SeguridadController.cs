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

            int largo = clave.Length;

            foreach (char c in clave)
            {
                if (char.IsUpper(c)) tieneMayus = true;
                if (char.IsLower(c)) tieneMinus = true;
                if (char.IsDigit(c)) tieneNumero = true;
            }

            bool cumpleLargo = largo >= 8;
            bool esSegura = cumpleLargo && tieneMayus && tieneMinus && tieneNumero;
        }

    }
}
