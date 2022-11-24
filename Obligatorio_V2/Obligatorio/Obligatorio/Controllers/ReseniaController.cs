using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio.Controllers
{
    public class ReseniaController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerResenias(string email)
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return Redirect("/login/index");
            }

            Periodista periodista = unS.GetPeriodistaPorEmail(email);
            List<Reseña> aux = periodista.GetResenias();
            aux.Sort();
            ViewBag.resenias = aux;
            ViewBag.emailPerio = periodista.Email;
            return View();


        }

        public IActionResult VerReseniasPersonales()
        {
            if (HttpContext.Session.GetString("rol") != "PERIODISTA")
            {
                return Redirect("/login/index");
            }
            else
            {
                string email = HttpContext.Session.GetString("email");
                Periodista periodista = unS.GetPeriodistaPorEmail(email);
                ViewBag.Periodista = periodista;
                ViewBag.Resenias = periodista.GetResenias();
                return View();
            }
        }

        [HttpGet]
        public IActionResult CrearResenia(int id, string mensajeError)
        {
            if (HttpContext.Session.GetString("rol") != "PERIODISTA")
            {
                return Redirect("/login/index");
            }
            else
            {
                Usuario periodista = unS.GetUsuarioPorEmail(HttpContext.Session.GetString("email"));
                ViewBag.IDPartido = id;
                ViewBag.Periodista = periodista;
                ViewBag.Partido = unS.GetPartido(id);
                ViewBag.Error = mensajeError;
                return View();
            }
        }

        [HttpPost]
        public IActionResult CrearResenia(string titulo, string contenido, DateTime fecha, int partido, string periodista)
        {
            if (HttpContext.Session.GetString("rol") != "PERIODISTA")
            {
                return Redirect("/login/index");
            }
            else
            {
                try
                {
                    Periodista MiPeriodista = unS.GetPeriodistaPorEmail(HttpContext.Session.GetString("email"));
                    Reseña resenia = new Reseña(titulo, contenido, fecha, MiPeriodista, unS.GetPartido(partido));
                    MiPeriodista.AgregarResenia(resenia);
                    return Redirect("/Resenia/VerReseniasPersonales");
                } catch (Exception e)
                {
                    ViewBag.IDPartido = partido;
                    ViewBag.Partido = unS.GetPartido(partido);
                    ViewBag.Error = e.Message;
                    return RedirectToAction("CrearResenia", new { mensajeError = e.Message, id = partido });
                }
            }
        }
    }
}
