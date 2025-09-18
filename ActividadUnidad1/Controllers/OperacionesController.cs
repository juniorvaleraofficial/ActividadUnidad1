using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class OperacionesController : Controller
    {
        // Métodos de lógica (no acción)
        private int SumarEnteros(int a, int b) => a + b;
        private int RestarEnteros(int a, int b) => a - b;
        private int MultiplicarEnteros(int a, int b) => a * b;

        //Operaciones/Sumar?n=5&n2=7
        [HttpGet]
        public IActionResult Sumar(int n = 0, int n2 = 0)
        {
            int resultado = SumarEnteros(n, n2);
            ViewBag.N1 = n;
            ViewBag.N2 = n2;
            ViewBag.Resultado = resultado;
            return View();
        }

        //Operaciones/Sumar/5/7
        [HttpGet("Operaciones/Sumar/{n:int}/{n2:int}")]
        public IActionResult SumarConRuta(int n, int n2) => Sumar(n, n2);

        public IActionResult Restar(int n = 0, int n2 = 0)
        {
            int resultado = RestarEnteros(n, n2);
            ViewBag.N1 = n;
            ViewBag.N2 = n2;
            ViewBag.Resultado = resultado;
            return View();
        }

        public IActionResult Multiplicar(int n = 0, int n2 = 0)
        {
            int resultado = MultiplicarEnteros(n, n2);
            ViewBag.N1 = n;
            ViewBag.N2 = n2;
            ViewBag.Resultado = resultado;
            return View();
        }

    }
}
