using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FaseEliminatorias : Partido
    {
        public bool Alargue { get; set; }
        public bool Penales { get; set; }

        public FaseEliminatorias( DateTime fechaPartido, Seleccion seleccionA, Seleccion seleccionB) : base(fechaPartido, seleccionA, seleccionB)
        {
            Alargue = false;
            Penales = false;
        }

        //-------------------------------INCIDENCIAS----------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public override void AgregarIncidencia(Incidencia incidencia)
        {
            if (incidencia == null)
            {
                throw new Exception("La incidencia no tiene datos");
            }
            bool estaJugador = false;

            //CHEQUEAR QUE EL JUGADOR ESTÉ EN ALGUNA DE LAS DOS SELECCIONES
            foreach (Jugador item in SeleccionA.Jugadores)
            {
                if (item.IDJugador == incidencia.UnJugador.IDJugador)
                {
                    estaJugador = true;
                }
            }
            foreach (Jugador item in SeleccionB.Jugadores)
            {
                if (item.IDJugador == incidencia.UnJugador.IDJugador)
                {
                    estaJugador = true;
                }
            }

            if (!estaJugador)
            {
                throw new Exception("El jugador indicado no está en las selecciones que se enfrentan");
            }

            
            Incidencias.Add(incidencia);
        }

        //-------------------------------FUNCIONES GENERALES---------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public override string ToString()
        {
            return $" -- FASE DE ELIMINATORIAS --\n" + base.ToString();
        }

    }
}
