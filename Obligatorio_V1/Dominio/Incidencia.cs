using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Incidencia
    {
        public string Tipo { get; set; }
        public int Minuto { get; set; }
        public Jugador UnJugador { get; set; }
        //public Seleccion UnaSeleccion { get; set; }

        public Incidencia(string tipo, int minuto, Jugador jugador)
        {
            Tipo = tipo;
            Minuto = minuto;
            UnJugador = jugador;
            //ValidarIncidencia();
        }

        public void ValidarIncidencia()
        {
            if (UnJugador == null)
            {
                throw new Exception("Falta la información del jugador");
            }
            
        }


    }
}
