using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Seleccion: IEquatable<Seleccion>, IComparable<Seleccion>
    {
        public Pais Pais { get; private set; }
        private List<Jugador> _jugadores = new List<Jugador>();

        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        public Seleccion(Pais pais)
        {
            Pais = pais;
            Validar();
        }

        public Seleccion(Pais pais, List<Jugador> jugadores)
        {
            Pais = pais;
            _jugadores = jugadores;
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

            if (Jugadores.Count < 11)
            {
                throw new Exception("Debe ingresar al menos 11 jugadores");
            }
        }

        //-------------------------------JUGADORES---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        //-------------------------------GENERALES---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public bool Equals([AllowNull] Seleccion other)
        {
            return Pais.Nombre.Equals(other.Pais.Nombre);
        }


        public override string ToString()
        {
            string texto = $"Pais: {Pais} \n";
            texto += $"Jugadores: {Jugadores.Count}\n";
            return texto;
        }

        public int CompareTo([AllowNull] Seleccion other)
        {
            return Pais.Nombre.CompareTo(other.Pais.Nombre);
        }
    }
}
