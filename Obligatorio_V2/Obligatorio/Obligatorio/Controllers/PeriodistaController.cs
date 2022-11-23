using Microsoft.AspNetCore.Mvc;
using System;
using Dominio;
using Microsoft.AspNetCore.Http;

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
                ViewBag.MensajeExito = "Usuario creado con éxito. Inicie sesión";
                return View();
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
