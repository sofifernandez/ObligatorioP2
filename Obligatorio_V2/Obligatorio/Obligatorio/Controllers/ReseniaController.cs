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

            Usuario periodista = unS.GetUsuarioPorEmail(email);
            ViewBag.resenias = periodista.GetResenias();
            return View();


        }

        //public IActionResult VerReseniasPersonales()
        //{
        //    return View();
        //}
    }
}
