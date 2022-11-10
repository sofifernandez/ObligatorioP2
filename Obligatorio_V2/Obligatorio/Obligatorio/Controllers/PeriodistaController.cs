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
            ViewBag.Periodistas = unS.Periodistas;
            return View();
        }

        public IActionResult CrearPeriodista()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearPeriodista(string nombreCompleto, string email, string password)
        {
            try
            {
                unS.ArmarPeriodista(nombreCompleto, email, password);
                return RedirectToAction("index");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                ViewBag.NombreCompleto = nombreCompleto;
                ViewBag.Email = email;
                ViewBag.Password = password;
                return View();
            }
        }
    }
}
