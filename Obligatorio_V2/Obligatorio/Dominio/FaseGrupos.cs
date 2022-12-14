using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FaseGrupos : Partido
    {
        public char Grupo { get; set; }

        public FaseGrupos(char grupo, DateTime fechaPartido, Seleccion seleccionA, Seleccion seleccionB, bool finalizado, string resultado) : base(fechaPartido, seleccionA, seleccionB, finalizado, resultado)
        {
            Grupo = grupo;
            ValidarGrupo();
        }

        //-------------------------------VALIDAR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void ValidarGrupo()
        {
            int ascii = (int)Grupo;
            if (ascii < 65 || ascii > 72)
            {
                throw new Exception("El grupo seleccionado es incorrecto");
            }
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
            foreach(Jugador item in SeleccionA.Jugadores)
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

            if (incidencia.Minuto < 0)// --> no hay definición por penales en fase de grupos así que el minuto no puede ser menor a 0
            {
                throw new Exception("El tiempo ingresado es incorrecto");
            }

            Incidencias.Add(incidencia);
        }


        public override void FinalizarPartido()
        {
            if (!Finalizado)
            {
                List<Incidencia> golesA = FiltrarIncidencias("Gol", SeleccionA.Pais.Nombre);
                List<Incidencia> golesB = FiltrarIncidencias("Gol", SeleccionB.Pais.Nombre);
                if (golesA.Count == golesB.Count)
                {
                    Resultado = "Empate";
                }
                else if (golesA.Count > golesB.Count)
                {
                    Resultado = $"Ganador: {SeleccionA.Pais.Nombre}";
                }
                else
                {
                    Resultado = $"Ganador: {SeleccionB.Pais.Nombre}";
                }
                Finalizado = true;
            }
        }

        //-------------------------------FUNCIONES GENERALES---------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public override char GetGrupo()
        {
            return Grupo;
        }

        public override string ToString()
        {
            return $" -- FASE DE GRUPOS -- {Grupo}\n" + base.ToString();
        }
    }
}
