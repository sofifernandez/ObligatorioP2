using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;
        private List<Partido> _partidos = new List<Partido>();
        private List<Periodista> _periodistas = new List<Periodista>();
        private List<Jugador> _jugadores = new List<Jugador>();
        private List<Pais> _paises = new List<Pais>();

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }

        }

        private Sistema()
        {
            Console.WriteLine(_paises.Count);
            PrecargarDatos();
            Console.WriteLine(_paises.Count);
        }

       

        private void PrecargarDatos()
        {
            AltaPais(new Pais("Catar", "QAT"));
            AltaJugador(new Jugador(38, "13", "Musab Khoder", DateTime.Parse("1993-01-01"), 1.74, "derecho", 325000, "EUR", GetPais("Catar"), "Lateral derecho"));
            
        }

        public void AltaPais(Pais pais)
        {
            if (pais == null)
            {
                throw new Exception("El empleado recibido no tiene datos.");
            }
            pais.Validar();
            if (_paises.Contains(pais))
            {
                throw new Exception($"La cedula {pais.IDPais} ya existe");
            }
            _paises.Add(pais);

        }

        public void AltaJugador(Jugador jugador)
        {
            if (jugador == null)
            {
                throw new Exception("El empleado recibido no tiene datos.");
            }
            jugador.Validar();
            if (_jugadores.Contains(jugador))
            {
                throw new Exception($"La cedula {jugador.IDJugador} ya existe");
            }
            _jugadores.Add(jugador);

        }

        private Pais GetPais(string nombrePais)
        {
            foreach (Pais item in _paises)
            {
                if (item.Nombre.Contains(nombrePais))
                {
                    return item;
                }


            }

            return null;
        }


    }
}
