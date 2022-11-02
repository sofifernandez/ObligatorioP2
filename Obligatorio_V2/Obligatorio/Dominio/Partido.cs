using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public abstract class Partido : IEquatable<Partido>

    {
        public int IDPartido { get; private set; }
        public DateTime FechaPartido { get; set; }
        public string Resultado { get; set; }
        public bool Finalizado { get; set; }
        public Seleccion SeleccionA { get; set; }
        public Seleccion SeleccionB { get; set; }

        private List<Incidencia> _incidencias = new List<Incidencia>();
        private List<Reseña> _reseñas = new List<Reseña>();
        private List<Jugador> _jugadores = new List<Jugador>();

        public List<Incidencia> Incidencias
        {
            get { return _incidencias; }
        }

        public List<Jugador> Jugadores
        {
            get { return _jugadores; }
        }

        private static int uldId;

        public Partido()
        {
            IDPartido = uldId++;
        }

        public Partido(DateTime fechaPartido, Seleccion seleccionA, Seleccion seleccionB)
        {
            IDPartido = uldId++;
            FechaPartido = fechaPartido;
            Resultado = "Pendiente";
            Finalizado = false;
            SeleccionA = seleccionA;
            SeleccionB = seleccionB;
            ValidarPartido();
        }

        //-------------------------------VALIDAR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void ValidarPartido()
        {
            if (SeleccionA == null || SeleccionB == null)
            {
                throw new Exception("Falta la información de las selecciones");
            }

            int nov = DateTime.Compare(FechaPartido, new DateTime(2022, 11, 20));
            int dec = DateTime.Compare(FechaPartido, new DateTime(2022, 12, 18));

            if (nov < 0 || dec > 0)
            {

                throw new Exception("La fecha debe estar comprendida entre el 20/11/2022 y el 18/12/2022");
            }
        }
        //-------------------------------FINALIZAR PARTIDO-----------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        // Observaciones para próxima entrega:
        // Fase de grupos puede haber empate, pero en eliminatorias no. Va a ser una función abstracta
        // Chequear que las incidencias de goles hayan sido de jugadores que efectivamente estuvieron en cancha (lista final de jugadores del partido)
        // Al menos 11 jugadores de cada selección.

        //public abstract void FinalizarPartido();


        //-------------------------------JUGADOR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public void AgregarJugador(Jugador unJugador)
        {
            bool esta=false;
            if (SeleccionA.Jugadores.Contains(unJugador))
            {
                _jugadores.Add(unJugador);
                esta = true;
            }

            if (SeleccionB.Jugadores.Contains(unJugador))
            {
                _jugadores.Add(unJugador);
                esta = true;
            }

            if (!esta)
            {
                throw new Exception($"El jugador {unJugador.NombreCompleto} no está en {SeleccionA.Pais.Nombre} vs {SeleccionB.Pais.Nombre}");
            }
        }


        //-------------------------------INCIDENCIAS----------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public abstract void AgregarIncidencia(Incidencia incidencia); //--> funci'n abstracta ver cada clasificación



        public List<Incidencia> FiltrarIncidencias(string tipo, string nombrePais=null) //--> filtrar incidencia segú tipo y selección si es que se indica
        {
            List<Incidencia> aux = new List<Incidencia>();
            if(nombrePais==null)
            {
                foreach (Incidencia item in _incidencias)
                {
                    if (item.Tipo == tipo)
                    {
                        aux.Add(item);
                    }
                }
                
            } else
            {
                foreach (Incidencia item in _incidencias)
                {
                    if (item.Tipo == tipo)
                    {
                        if (item.UnJugador.Pais.Nombre.ToLower() == nombrePais.ToLower())
                        {
                            aux.Add(item);
                        }
                        
                    }
                }
                
            }
            return aux;

        }





        //-------------------------------FUNCIONES GENERALES---------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public bool Equals([AllowNull] Partido other)
        {
            return SeleccionA.Pais.Nombre.Equals(other.SeleccionA.Pais.Nombre) && SeleccionB.Pais.Nombre.Equals(other.SeleccionB.Pais.Nombre) && FechaPartido.Equals(other.FechaPartido);

        }

        public override string ToString()
        {
            string respuesta = "";
            respuesta += $"ID: {IDPartido} \n";
            respuesta += $"Fecha: {FechaPartido} \n";
            respuesta += $"Seleccion A: {SeleccionA.Pais.Nombre} \n";
            respuesta += $"Seleccion B: {SeleccionB.Pais.Nombre} \n";
            respuesta += $"Finalizado: {Finalizado} \n";
            respuesta += $"Resultado: {Resultado} \n";
            respuesta += "------------------------------------ \n";
            if (_incidencias.Count > 0)
            {
                respuesta += "Incidencias del partido:\n";
                respuesta += $"Goles: {FiltrarIncidencias("Gol").Count}\n";
                respuesta += $"Rojas: {FiltrarIncidencias("Roja").Count}\n";
                respuesta += $"Amarillas: {FiltrarIncidencias("Amarilla").Count}";

            }
            else
            {
                respuesta += "Todavía no existen incidencias";
            }
            return respuesta;
        }
    }
}
