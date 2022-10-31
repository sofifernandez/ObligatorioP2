using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace Obligatorio.Controllers
{
    public class PeriodistaController : Controller
    {
        Sistema unS = Sistema.Instancia;
        public IActionResult Index()
        {
            return View();
        }
    }
}
