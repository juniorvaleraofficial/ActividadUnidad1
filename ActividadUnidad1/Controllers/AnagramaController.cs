using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace MiApp.Controllers
{
    [Route("Anagrama")]
    public class AnagramaController : Controller
    {
        [HttpGet("Verificar/{a}/{b}")]
        public IActionResult Verificar(string a, string b)
        {
            bool esAnagrama = SonAnagramas(a, b);
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.EsAnagrama = esAnagrama;
            return View();
        }

        private static bool SonAnagramas(string x, string y)
        {
            string normX = new string(
                x.ToLowerInvariant().Where(ch => !char.IsWhiteSpace(ch)).ToArray()
            );
            string normY = new string(
                y.ToLowerInvariant().Where(ch => !char.IsWhiteSpace(ch)).ToArray()
            );

            if (normX.Length != normY.Length) return false;

            var sx = normX.OrderBy(c => c).ToArray();
            var sy = normY.OrderBy(c => c).ToArray();
            return sx.SequenceEqual(sy);
        }
    }
}

