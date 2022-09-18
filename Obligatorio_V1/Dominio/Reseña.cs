﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Reseña
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPubli { get; set; }
        public Periodista UnPeriodista { get; set; }

        public Reseña(string titulo, string contenido, DateTime fecha, Periodista periodista)
        {
            Titulo = titulo;
            Contenido = contenido;
            FechaPubli = fecha;
            UnPeriodista = periodista;
            //Validar();
        }
    }
}
