using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
       
        public ActionResult Usuario(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return Content("No se recibió un correo válido.");
            }

            
        }
    }
}