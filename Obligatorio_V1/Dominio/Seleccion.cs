using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Seleccion
    {
        public Pais Pais { get; private set; }
        public List<Jugador> Jugadores { get; set; }

        public Seleccion()
        {
        }

        public Seleccion(Pais pais, List<Jugador> jugadores)
        {
            Pais = pais;
            Jugadores = jugadores;


            //Validar()

        }

        public override string ToString()
        {
            string texto = $"{Pais}";
            texto += $"Jugadores";

            foreach (Jugador item in Jugadores)
            {
                texto += $"{Jugador.NombreCompleto}";
            }

            return texto;
        }
    }
}
