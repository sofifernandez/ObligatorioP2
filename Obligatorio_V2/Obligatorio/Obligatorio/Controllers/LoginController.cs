﻿using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Obligatorio.Controllers
{
    public class LoginController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult Index()
        {
            ViewBag.Partidos = unS.Partidos;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            try
            {
                unS.Login(email, password);
                string rol = unS.GetRol(email);
                HttpContext.Session.SetString("email", email);
                HttpContext.Session.SetString("rol", rol);
                return Redirect("/Home/Index");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                ViewBag.Partidos = unS.Partidos;
                return View("index");
            }
        }
    }
}