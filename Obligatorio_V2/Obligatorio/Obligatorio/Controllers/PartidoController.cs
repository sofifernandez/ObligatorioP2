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
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("rol")))
            {
                return Redirect("/login/index");
            }
            (List<Partido> partidosGrupo, List<Partido> partidosEliminatoria) = unS.ClasificarPartidos();
            ViewBag.PartidosGrupo = partidosGrupo;
            ViewBag.PartidosEliminatoria = partidosEliminatoria;
            return View();
         }

        //SOLO OPERADOR--------------------------------------------------------------------------------------
        public IActionResult FinalizarPartido (int id)
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return Redirect("/login/index");
            }
            unS.FinalizarPartido(id);
            return RedirectToAction("VerPartidos");
        }

        //SOLO OPERADOR--------------------------------------------------------------------------------------
        public IActionResult InfoPartidos()
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return Redirect("/login/index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult InfoPartidos(DateTime fecha1, DateTime fecha2)
        {
            try
            {
                
                List<Partido> aux= unS.FinalizadosEntreFechas(fecha1, fecha2);
                ViewBag.partidos = aux;
               
                if (aux.Count==0)
                {
                    ViewBag.Mensaje = "No hay partidos entre las fechas seleccionadas";
                }
                return View();
            }
            catch (Exception e)
            {

                ViewBag.Error = e.Message;
                return View();
            }
        }
    }
}
