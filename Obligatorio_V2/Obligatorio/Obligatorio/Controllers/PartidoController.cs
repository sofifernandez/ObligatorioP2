using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Http;

namespace Obligatorio.Controllers
{
    public class PartidoController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult VerPartidos()
        {
            if (HttpContext.Session.GetString("rol") == "")
            {
                return Redirect("/login/index");
            }
            (List<Partido> partidosGrupo, List<Partido> partidosEliminatoria) = unS.ClasificarPartidos();
            ViewBag.PartidosGrupo = partidosGrupo;
            ViewBag.PartidosEliminatoria = partidosEliminatoria;
            return View();
         }

        public IActionResult FinalizarPartido (int id)
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return View("index");
            }
            unS.FinalizarPartido(id);
            return RedirectToAction("VerPartidos");
        }
    }
}
