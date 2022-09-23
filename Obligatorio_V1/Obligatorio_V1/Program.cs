using Dominio;
using System;

namespace Obligatorio_V1
{
    class Program
    {
        static Sistema unS = Sistema.Instancia;
        static void Main(string[] args)
        {
            MostrarPaises();
            MostrarJugadores();
            MostrarSelecciones();
            
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
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
        }

        static void MostrarJugadores()
        {
            Console.WriteLine("Jugadores:");
            foreach (Jugador item in unS.Jugadores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }

        static void MostrarSelecciones()
        {
            Console.WriteLine("Selecciones:");
            foreach (Seleccion item in unS.Selecciones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        }
    }
}
