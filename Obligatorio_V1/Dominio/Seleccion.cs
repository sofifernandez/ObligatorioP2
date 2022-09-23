using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Seleccion
    {
        public Pais Pais { get; private set; }
        private List<Jugador> Jugadores = new List<Jugador>();

        public Seleccion(Pais pais)
        {
            Pais = pais;
            Validar();
        }

        public Seleccion(Pais pais, List<Jugador> jugadores)
        {
            Pais = pais;
            Jugadores = jugadores;
            Validar();
        }

        //-------------------------------VALIDAR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void Validar()
        {
            ValidarPais();
            ValidarJugadores();
        }

        public void ValidarPais()
        {
            if (Pais == null)
            {
                throw new Exception("Debe ingresar un país.");
            }
        }
        public void ValidarJugadores()
        {
            //if (Jugadores.Count < 11)
            //{
            //    throw new Exception("Debe ingresar al menos 11 jugadores");
            //}
        }

        //-------------------------------GENERAL---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }
        public override string ToString()
        {
            string texto = $"Pais: {Pais} \n";
            texto += $"Jugadores: \n";

            foreach (Jugador item in Jugadores)
            {
                texto += $"{item.NombreCompleto} \n";
            }

            return texto;
        }
    }
}
