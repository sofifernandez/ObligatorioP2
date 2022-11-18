﻿using Microsoft.AspNetCore.Mvc;
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
                return View("VerPartidos");
            }
            unS.FinalizarPartido(id);
            return RedirectToAction("VerPartidos");
        }

        //SOLO OPERADOR--------------------------------------------------------------------------------------
        public IActionResult InfoPartidos()
        {
            if (HttpContext.Session.GetString("rol") != "OPERADOR")
            {
                return RedirectToAction("/login/index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult InfoPartidos(DateTime fecha1, DateTime fecha2)
        {
            try
            {
                ViewBag.partidos = unS.FinalizadosEntreFechas(fecha1, fecha2);
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
