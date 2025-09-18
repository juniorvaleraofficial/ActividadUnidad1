using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ActividadUnidad1.Controllers
{
    [Route("[controller]")] // base => /Fecha
    public class FechaController : Controller
    {
        // GET /Fecha/DiaSemana/2025-09-13
        [HttpGet("DiaSemana/{fecha}")]
        public IActionResult DiaSemana(string fecha)
        {
            // 1) Validar y convertir "yyyy-MM-dd" -> DateTime
            if (!DateTime.TryParseExact(
                    fecha,                // viene de la URL
                    "yyyy-MM-dd",         // formato esperado
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var f))
            {
                return BadRequest("Usa el formato yyyy-MM-dd. Ej: /Fecha/DiaSemana/2025-09-13");
            }

            // 2) Obtener el nombre del día en español
            var es = new CultureInfo("es-ES");
            string dia = es.TextInfo.ToTitleCase(f.ToString("dddd", es)); // "Sábado"

            // 3) Enviar datos a la vista
            ViewBag.Fecha = f.ToString("yyyy-MM-dd");
            ViewBag.Dia = dia;

            return View();
        }
    }
}
