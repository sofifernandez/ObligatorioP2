using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Dominio
{
    public class FaseEliminatorias : Partido
    {
        public bool Alargue { get; set; }
        public bool Penales { get; set; }

        public FaseEliminatorias( DateTime fechaPartido, Seleccion seleccionA, Seleccion seleccionB, bool finalizado, string resultado) : base(fechaPartido, seleccionA, seleccionB, finalizado, resultado)
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

            if (incidencia.Minuto < -1) //--> en eliminatorias puede ser -1, por la definición por penales, pero no menor
            {
                throw new Exception("El minuto ingresado no es correcto");
            }


            Incidencias.Add(incidencia);
        }

        public override void FinalizarPartido()
        {
            if (!Finalizado)
            {
                List<Incidencia> golesTotales = FiltrarIncidencias("Gol");
                List<Incidencia> golesA = FiltrarIncidencias("Gol", SeleccionA.Pais.Nombre);
                List<Incidencia> golesB = FiltrarIncidencias("Gol", SeleccionB.Pais.Nombre);
                bool penales = false;

                // Que chequee si hay penales en la lista de incidencias (goles en minuto negativo)
                foreach (Incidencia item in golesTotales)
                {
                    if (item.Minuto < 0)
                    {
                        penales = true;
                    }
                }

                if (penales)
                {
                    if (golesA.Count > golesB.Count)
                    {
                        Resultado = $"Empate en tiempo de juego. Ganador {SeleccionA.Pais.Nombre} en tanda de penales";
                    }
                    else
                    {
                        Resultado = $"Empate en tiempo de juego. Ganador {SeleccionB.Pais.Nombre} en tanda de penales";
                    }
                }
                else
                {
                    if (golesA.Count > golesB.Count)
                    {
                        Resultado = $"Ganador: {SeleccionA.Pais.Nombre}";
                    }
                    else
                    {
                        Resultado = $"Ganador: {SeleccionB.Pais.Nombre}";
                    }
                }
                Finalizado = true;
            }
        }

        //-------------------------------FUNCIONES GENERALES---------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public override char GetGrupo() { return 'z'; }

        public override string ToString()
        {
            return $" -- FASE DE ELIMINATORIAS --\n" + base.ToString();
        }

    }
}
