using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio.Controllers
{
    public class PartidoController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult VerPartidos()
        {
            (List<Partido> partidosGrupo, List<Partido> partidosEliminatoria) = unS.ClasificarPartidos();
            ViewBag.PartidosGrupo = partidosGrupo;
            ViewBag.PartidosEliminatoria = partidosEliminatoria;
            return View();
        }

        public IActionResult FinalizarPartido (int id)
        {
            unS.FinalizarPartido(id);
            return RedirectToAction("VerPartidos");
        }
    }
}
