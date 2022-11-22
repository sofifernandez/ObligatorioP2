﻿using Microsoft.AspNetCore.Http;
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

            Usuario periodista = unS.GetUsuarioPorEmail(email);
            ViewBag.resenias = periodista.GetResenias();
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
                Usuario periodista = unS.GetUsuarioPorEmail(email);
                ViewBag.Periodista = periodista;
                ViewBag.Resenias = periodista.GetResenias();
                return View();
            }
        }

        [HttpGet]
        public IActionResult CrearResenia(int id)
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
                    ViewBag.Error = e.Message;
                    return View();
                }
            }
        }
    }
}
