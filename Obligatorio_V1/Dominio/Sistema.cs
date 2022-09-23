using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;
        private List<Partido> _partidos = new List<Partido>();
        private List<Periodista> _periodistas = new List<Periodista>();
        private List<Jugador> _jugadores = new List<Jugador>();
        private List<Pais> _paises = new List<Pais>();
        private List<Seleccion> _selecciones = new List<Seleccion>();
        

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
            Console.WriteLine("Ingrese un monto de referencia para las categorias de los jugadores:");
            int MontoRef = int.Parse(Console.ReadLine());
            PrecargarDatos(MontoRef);

        }

        public List<Pais> Paises
        {
            get { return _paises; }
        }

        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        public List<Seleccion> Selecciones
        {
            get { return _selecciones; }
        }

        public List<Partido> Partidos
        {
            get { return _partidos; }
        }
        public List<Periodista> Periodistas
        {
            get { return _periodistas; }
        }


        //-------------------------------PRECARGA---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        private void PrecargarDatos(int MontoRef)
        {
            AltaPais(new Pais("Catar", "QAT"));
            PrecargaJugadores();
            AgregarCategoria(MontoRef);
            PrecargaSelecciones();
        }

        private void PrecargaJugadores()
        {
            AltaJugador(new Jugador(38, "13", "Musab Khoder", DateTime.Parse("1993-01-01"), 1.74, "derecho", 325000, "EUR", GetPais("Catar"), "Lateral derecho"));
        }

        private void AgregarCategoria(int MontoRef)
        {
            foreach (Jugador item in Jugadores)
            {
                item.DetCategoria(MontoRef);
            }
        }

        private void PrecargaSelecciones()
        {
            //contamos con países y jugadores, la seleccion debe armar para cada pais una seleccion
            foreach (Pais p in _paises)
            {
                // 1 - se crea una seleccion por cada país en la lista.
                Seleccion selnueva = new Seleccion(p);
                List<Jugador> misjugadores = JugadoresDe(p);
                foreach (Jugador j in misjugadores)
                {
                    selnueva.AgregarJugador(j);
                }
                AltaSeleccion(selnueva);
            }
        }

        //-------------------------------ALTAS---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public void AltaSeleccion(Seleccion seleccion)
        {
            if (seleccion == null)
            {
                throw new Exception("La seleccion recibida no tiene datos.");
            }
            if (_selecciones.Contains(seleccion))
            {
                throw new Exception($"La seleccion ya existe");
            }
            _selecciones.Add(seleccion);
        }


        public void AltaPais(Pais pais)
        {
            if (pais == null)
            {
                throw new Exception("El pais recibido no tiene datos.");
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

        //-------------------------------GENERAL---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

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

        private List<Jugador> JugadoresDe(Pais p)
        {
            List<Jugador> _misJugadores = new List<Jugador>();
            foreach (Jugador j in Jugadores)
            {

                if (j.Pais.Nombre.Equals(p.Nombre))
                {
                    _misJugadores.Add(j);
                }
            }
            return _misJugadores;
        }
    }
}
