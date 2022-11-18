using Microsoft.AspNetCore.Mvc;
using System;
using Dominio;

namespace Obligatorio.Controllers
{
    public class PeriodistaController : Controller
    {
        Sistema unS = Sistema.Instancia;

        public IActionResult Index(Periodista periodista)
        {
            ViewBag.Periodistas = unS.FiltrarTipoUsuario("PERIODISTA");
            return View();
        }

        public IActionResult CrearPeriodista()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearPeriodista(string nombre, string apellido, string email, string password)
        {
            try
            {
                unS.ArmarPeriodista(nombre, apellido, email, password);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                ViewBag.Nombre = nombre;
                ViewBag.Apellido = apellido;
                ViewBag.Email = email;
                ViewBag.Password = password;
                return View();
            }
        }
    }
}
