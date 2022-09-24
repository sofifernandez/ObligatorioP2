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

        //-------------------------------LISTAS QUE ACCEDE EL SISTEMA------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
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
            AltaPais(new Pais("Uruguay", "URU"));
            AltaPais(new Pais("Ecuador", "ECU"));
            PrecargaJugadores();
            AgregarCategoria(MontoRef);
            PrecargaSelecciones();
            PrecargaPartidos();
            AltaPeriodista(new Periodista("Pepito Garcia", "pepito@gmail.com", "jkshdfjksdhskjd"));
            
        }

        private void PrecargaJugadores()
        {
            AltaJugador(new Jugador(38, "13", "Musab Khoder", DateTime.Parse("1993-01-01"), 1.74, "derecho", 325000, "EUR", GetPais("Catar"), "Lateral derecho"));
            AltaJugador(new Jugador(479, "12", "Sergio Rochet", DateTime.Parse("1993-03-23"), 1.9, "derecho", 3000000, "EUR", GetPais("Uruguay"), "Portero"));
            AltaJugador(new Jugador(476, "11", "Jordy Caicedo", DateTime.Parse("1997-11-18"), 1.87, "derecho", 2000000, "EUR", GetPais("Ecuador"), "Delantero centro"));
            AltaJugador(new Jugador(480, "23", "Sebastián Sosa", DateTime.Parse("1986-08-19"), 1.81, "derecho", 2000000, "EUR", GetPais("Uruguay"), "Portero"));
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
            foreach (Pais p in _paises)
            {
                
                List<Jugador> misjugadores = JugadoresDe(p);
                Seleccion selnueva = new Seleccion(p, misjugadores);
                //foreach (Jugador j in misjugadores)
                //{
                //    selnueva.AgregarJugador(j);
                //}
                AltaSeleccion(selnueva);
            }
        }

        private void PrecargaPartidos()
        {
            Partido unP1 = new FaseGrupos('A', new DateTime(2022, 11, 21), GetSeleccion("Uruguay"), GetSeleccion("Catar"));
            Partido unP2 = new FaseGrupos('A', new DateTime(2022, 11, 22), GetSeleccion("Uruguay"), GetSeleccion("Ecuador"));
            //partido 1
            unP1.AgregarIncidencia(new Incidencia("Roja", 50, GetJugador(38)));
            unP1.AgregarIncidencia(new Incidencia("Roja", 30, GetJugador(479)));
            unP1.AgregarIncidencia(new Incidencia("Roja", 30, GetJugador(480)));
            unP1.AgregarIncidencia(new Incidencia("Gol", 25, GetJugador(479)));
            //partido 2
            unP2.AgregarIncidencia(new Incidencia("Gol", 25, GetJugador(479)));
            unP2.AgregarIncidencia(new Incidencia("Gol", 30, GetJugador(479)));
            unP2.AgregarIncidencia(new Incidencia("Gol", 30, GetJugador(476)));

            //unP1.AgregarIncidencia(new Incidencia("Roja", 50, GetJugador(476))); //--> ESTO NO FUNCIONA PORQUE ES UN JUGADOR DE ECUADOR Y EL PARTIDO ES URU VS QTAR
            AltaPartido(unP1);
            AltaPartido(unP2);
            PartidosJugador(38);
        }

        //-------------------------------ALTAS---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        //todo : da un error aca, lo saco para poder seguir
        public void AltaSeleccion(Seleccion seleccion)
        {
            if (seleccion == null)
            {
                throw new Exception("La seleccion recibida no tiene datos.");
            }
            if (_selecciones.Contains(seleccion))
            {
                throw new Exception($"La seleccion ya existe!");
            }
            _selecciones.Add(seleccion);
        }


        public void AltaPais(Pais pais)
        {
            if (pais == null)
            {
                throw new Exception("El pais recibido no tiene datos.");
            }
            if (_paises.Contains(pais))
            {
                throw new Exception($"El pais {pais.IDPais} ya existe");
            }
            _paises.Add(pais);

        }

        public void AltaJugador(Jugador jugador)
        {
            if (jugador == null)
            {
                throw new Exception("El Jugaror recibido no tiene datos.");
            }
            jugador.Validar();
            if (_jugadores.Contains(jugador))
            {
                throw new Exception($"El jugador {jugador.IDJugador} ya existe");
            }
            _jugadores.Add(jugador);
        }

        public void AltaPartido(Partido partido)
        {
            if (partido == null)
            {
                throw new Exception("Faltan datos del partido");
            }

            if (_partidos.Contains(partido))
            {
                throw new Exception($"El partido {partido.SeleccionA.Pais.Nombre} vs {partido.SeleccionB.Pais.Nombre} con fecha {partido.FechaPartido}  ya existe");
            }
            _partidos.Add(partido);
        }

        public void AltaPeriodista(Periodista periodista)
        {
            if (periodista == null)
            {
                throw new Exception("Faltan datos del partido");
            }
            if (_periodistas.Contains(periodista))
            {
                throw new Exception($"El {periodista.NombreCompleto} ya existe en el sistema");
            }
            _periodistas.Add(periodista);
        }

        //-------------------------------FUNCIONALIDAD PAISES------------------------------------------------------//
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

        //-------------------------------FUNCIONALIDAD JUGADORES---------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

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

        public Jugador GetJugador(int ID)
        {
            foreach(Jugador j in Jugadores)
            {
                if (j.IDJugador == ID)
                {
                    return j;
                }
            }
            return null;
        }

        public List<Partido> PartidosJugador(int IDJugador)
        {
            List<Partido> _misPartidos = new List<Partido>();
            foreach (Partido p in Partidos)
            {
                foreach(Jugador j in p.SeleccionA.Jugadores)
                {
                    if(j.IDJugador== IDJugador)
                    {
                        _misPartidos.Add(p);
                    }
                }

                foreach (Jugador j in p.SeleccionB.Jugadores)
                {
                    if (j.IDJugador == IDJugador)
                    {
                        _misPartidos.Add(p);
                    }
                }

            }
            return _misPartidos; ;
        }

        //todo : chequear que no se agreguen los jugadores más de una vez
        public List<Jugador> JugadoresExpulsados()
        {
            List<Jugador> _misJugadores = new List<Jugador>();
            foreach (Partido p in Partidos)
            {
                foreach(Incidencia i in p.Incidencias)
                {
                    if (i.Tipo == "Roja")
                    {
                        if (!_misJugadores.Contains(i.UnJugador))
                        {
                            _misJugadores.Add(i.UnJugador);
                        }
                    }
                }
            }
            _misJugadores.Sort();
            return _misJugadores;
        }

        public List<Jugador> JugadoresGoles()
        {
            List<Jugador> _misJugadores = new List<Jugador>();
            foreach(Partido p in Partidos)
            {
                List<Incidencia> _misIncidencias = p.FiltrarIncidencias("Gol");
                foreach(Incidencia i in _misIncidencias)
                {
                    if (!_misJugadores.Contains(i.UnJugador))
                    {
                        _misJugadores.Add(i.UnJugador);
                    }
                }

            }
            return _misJugadores;
        }

        
        //-------------------------------FUNCIONALIDAD SELECCIONES------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        //todo conviene hacer con == o con Contains para un string??
        private Seleccion GetSeleccion(string nombreSelec)
        {
            foreach (Seleccion item in _selecciones)
            {
                if (item.Pais.Nombre==nombreSelec)
                {
                    return item;
                }
            }
            return null;
        }

        //todo terminar esto
        public (Partido, int) PartidoMasGoles(string nombreSelec)
        {
            //Seleccion unaS = GetSeleccion(nombreSelc);
            int masGoles = 0;
            Partido partidoGoles = null;
            foreach(Partido p in Partidos)
            {
                int cantGoles = 0;
                List<Incidencia> _misIncidencias= p.FiltrarIncidencias("Gol", nombreSelec);
                foreach(Incidencia i in _misIncidencias)
                {
                   
                       cantGoles++;
                    
                }
                if (cantGoles > masGoles)
                {
                    masGoles = cantGoles;
                    partidoGoles = p;
                }
            }
            return (partidoGoles, masGoles);
        }
    }
}
