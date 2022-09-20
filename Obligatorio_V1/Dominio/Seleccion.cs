using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Seleccion
    {
        public Pais Pais { get; private set; }
        public List<Jugador> Jugadores { get; set; }

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
            if (Jugadores.Count < 11)
            {
                throw new Exception("Debe ingresar al menos 11 jugadores");
            }
        }
        public override string ToString()
        {
            string texto = $"{Pais}";
            texto += $"Jugadores";

            foreach (Jugador item in Jugadores)
            {
                texto += $"{item.NombreCompleto}";
            }

            return texto;
        }
    }
}
