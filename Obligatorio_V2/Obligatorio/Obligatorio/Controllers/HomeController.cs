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
            string rol = HttpContext.Session.GetString("rol");
            ViewBag.Rol = rol;
            return View();
            
           
        }

        public IActionResult VerSelecciones()
        {
            //unS.PrecargarDatos();
            List<Seleccion> selec = unS.Selecciones;
            selec.Sort();
            ViewBag.Selecciones = selec;

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
