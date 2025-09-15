using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace ActividadUnidad1.Controllers
{
    public class OracionController : Controller
    {
        public IActionResult ContarVocales()
        {
            string frase = "Hola";
            int contador = 0;
            string[] vocales = { "a", "e", "i", "o", "u" };

            foreach (char letra in frase.ToLower()) // recorremos la frase en minúsculas
            {
                if (vocales.Contains(letra.ToString())) // verificamos si la letra está en el array
                {
                    contador++;
                }
            }

            Console.WriteLine("Cantidad de vocales: " + contador);
            return View();
        }
    }
}
