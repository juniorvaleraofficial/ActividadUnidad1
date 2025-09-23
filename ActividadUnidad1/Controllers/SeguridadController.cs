using Microsoft.AspNetCore.Mvc;

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

            if (esSegura)
            {
                ViewBag.Resultado = "Contraseña Segura: ";
                ViewBag.EsSegura = true;
            }
            else
            {
                string faltantes = "";
                if (!cumpleLargo) faltantes += "• Tener al menos 8 caracteres\n";
                if (!tieneMayus) faltantes += "• Incluir al menos 1 mayúscula\n";
                if (!tieneMinus) faltantes += "• Incluir al menos 1 minúscula\n";
                if (!tieneNumero) faltantes += "• Incluir al menos 1 número\n";

                ViewBag.Resultado = "Contraseña NO segura. Revisa:\n" + faltantes;
                ViewBag.EsSegura = false;
            }

            return View();
        }

    }
}
