using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_1.Models;
using Ejercicio_1.Helpers;

namespace Ejercicio_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Index(Valor a)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Presentar", a);
            return View(a);
        }

        public IActionResult Presentar(Valor a)
        {
            var invertido = new Valor { numero = Invertir.nuevo(a.numero) };
            return View(invertido);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
