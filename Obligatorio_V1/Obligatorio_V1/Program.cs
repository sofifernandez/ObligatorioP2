using Dominio;
using System;

namespace Obligatorio_V1
{
    class Program
    {
        static Sistema unS = Sistema.Instancia;
        static void Main(string[] args)
        {
            //MostrarPaises();
            //MostrarJugadores();
            //MostrarSelecciones();
            //MostrarPartidos();
            //MostrarPeriodistas();
            MostrarPartidosJugador(38);
            MostrarJugadoresExpulsados();
            Console.ReadKey();
        }

        //-------------------------------MOSTRAR DATA---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        static void MostrarPaises()
        {
            Console.WriteLine("Paises:");
            foreach (Pais item in unS.Paises)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------\n");
        }

        static void MostrarJugadores()
        {
            Console.WriteLine("Jugadores:");
            foreach (Jugador item in unS.Jugadores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
        }

        static void MostrarSelecciones()
        {
            Console.WriteLine("Selecciones:");
            foreach (Seleccion item in unS.Selecciones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
        }

        static void MostrarPartidos()
        {
            Console.WriteLine("Partidos:");
            foreach (Partido item in unS.Partidos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
        }

        static void MostrarPeriodistas()
        {
            Console.WriteLine("Periodistas:");
            foreach (Periodista item in unS.Periodistas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");

        }

        static void MostrarPartidosJugador(int IDJugador)
        {
            Jugador unJ = unS.GetJugador(IDJugador);
            if(unJ != null)
            {
                foreach(Partido p in unS.PartidosJugador(IDJugador))
                {
                    Console.WriteLine($"Partidos jugados por {unJ.NombreCompleto}:\n");
                    string resp = "";
                    resp += $"Partido: {p.SeleccionA.Pais.Nombre} vs {p.SeleccionB.Pais.Nombre}\n";
                    resp += $"Fecha: {p.FechaPartido}\n";
                    resp += $"Incidencias: {p.Incidencias.Count}";
                    Console.WriteLine(resp);
                }
            }
            else
            {
                Console.WriteLine("El jugador seleccionado no existe");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");

        }

        static void MostrarJugadoresExpulsados()
        {
            Console.WriteLine("Jugadores Expulsados \n");
            foreach(Jugador j in unS.JugadoresExpulsados())
            {
                string resp = "";
                resp += $"Nombre: {j.NombreCompleto}\n";
                resp += $"Valor mercado: {j.ValorMercado}\n";
                Console.WriteLine(resp);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
        }
    }
}
