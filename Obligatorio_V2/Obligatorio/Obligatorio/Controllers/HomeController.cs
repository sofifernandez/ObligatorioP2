using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;

namespace Obligatorio.Controllers
{
    public class HomeController : Controller
    {
        Sistema unS = Sistema.Instancia;
        private readonly ILogger<HomeController> _logger;
        public bool sePrecargo = false;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("rol")))
            {
                return Redirect("/login/index");
            }
            string nombre = HttpContext.Session.GetString("nombre");
            string rol = HttpContext.Session.GetString("rol");
            ViewBag.nombre = nombre;
            ViewBag.rol = rol;
            return View();
        }

        public IActionResult VerSelecciones()
        {
            List<Seleccion> selec = unS.Selecciones;
            selec.Sort();
            ViewBag.Selecciones = selec;
            return View();
        }

        //SOLO OPERADORES---------------------------------------------------------------------------------
        public IActionResult VerPeriodistas()
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return Redirect("/login/index");
            }
            List<Usuario> aux= unS.FiltrarTipoUsuario("PERIODISTA");
            aux.Sort();
            ViewBag.periodistas = aux;
            return View();

        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
