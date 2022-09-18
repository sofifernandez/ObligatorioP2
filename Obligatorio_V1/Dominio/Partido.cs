using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Partido
    {
        public int IDPartido { get; private set; }
        public DateTime FechaPartido { get; set; }
        public string Resultado { get; set; }
        public bool Finalizado { get; set; }

        //private List<Incidencias> _incidencias = new List<Incidencias>();
        private List<Seleccion> _seleccionesEnfrent = new List<Seleccion>();
        private List<Reseña> _reseñas = new List<Reseña>();


        private static int uldId;

        public Partido()
        {
            IDPartido = uldId++;
        }
        public Partido(DateTime fechaPartido, string resultado, bool finalizado, List<Seleccion> selecciones)
        {
            IDPartido = uldId++;
            FechaPartido = fechaPartido;
            Resultado = resultado;
            Finalizado = finalizado;
            _seleccionesEnfrent = selecciones;


            //Validar();
        }
    }
}
