using Dominio;
using System;

namespace Obligatorio_V1
{
    class Program
    {
        static Sistema unS = Sistema.Instancia;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = PedirNumero();

                switch (opcion)
                {
                    case 1:
                        MenuAltaPeriodista();
                        break;
                    case 2:
                        MenuAsignarValorReferencia();
                        break;
                    case 3:
                        MenuPartidosDeJugador();
                        break;
                    case 4:
                        MenuJugadoresExpuslados();
                        break;
                    case 5:
                        MenuPartidoMasGoles();
                        break;
                    case 6:
                        MenuJugadoresConGol();
                        break;
                }
            } while (opcion != 0);

        }

        static void MostrarMenu()
        {
            Console.WriteLine("\n Ingrese una de las siguientes opciones: \n");
            Console.WriteLine("" +
                "1 - Dar de alta un periodista \n" +
                "2 - Asignar valor de referencia para la categoria financiera de los jugadores \n" +
                "3 - Listar todos partidos de un jugador \n" +
                "4 - Listar los jugadores que han sido expulsados \n" +
                "5 - Mostrar el partido con mas goles de una selección \n" +
                "6 - Listar jugadores que han convertido gol \n" +
                "0 - Salir \n"
            );
            Console.WriteLine("Ingrese su número a continuación:");        
        }

        static private int PedirNumero()
        {
            bool salir = false;
            int numero = 0;

            do
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    salir = true;
                }
                catch (Exception)
                {
                    //MensajesError("Solo debe ingresar numeros");
                    salir = false;
                }
            } while (!salir);

            return numero;
        }

        static string MenuAltaPeriodista()
        {
            Console.WriteLine("Ingrese el nombre completo:");
            string nombreCompleto = Console.ReadLine();

            Console.WriteLine("Ingrese el email:");
            string email = Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña:");
            string password = Console.ReadLine();

            return unS.ArmarPeriodista(nombreCompleto, email, password);
        }

        static void MenuAsignarValorReferencia()
        {
            Console.WriteLine("Ingrese un monto, el cual servirá de referencia para calcular la categoria financiera de los jugadores:");
            int monto = int.Parse(Console.ReadLine());

            unS.AgregarCategoria(monto);
        }

        static void MenuPartidosDeJugador()
        {
            Console.WriteLine("Ingrese el ID de un jugador para mostrar todos los partidos en los que ha participado:");
            int id = int.Parse(Console.ReadLine());

            MostrarPartidosJugador(id);
        }

        static void MenuJugadoresExpuslados()
        {
            MostrarJugadoresExpulsados();
        }

        static void MenuPartidoMasGoles()
        {
            Console.WriteLine("Ingrese el nombre de una selección:");
            string nombreSeleccion = Console.ReadLine();
            MostrarPartidoMasGoles(nombreSeleccion);
        }

        static void MenuJugadoresConGol()
        {
            MostrarJugadoresGoles();
        }

        static void FuncionesDePrueba()
        {
            //MostrarPaises();
            //MostrarJugadores();
            //MostrarSelecciones();
            //MostrarPartidos();
            MostrarPeriodistas();
            MostrarPartidosJugador(38);
            MostrarJugadoresExpulsados();
            MostrarPartidoMasGoles("Uruguay");
            MostrarJugadoresGoles();
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
            if (unJ != null)
            {
                foreach (Partido p in unS.PartidosJugador(IDJugador))
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
            foreach (Jugador j in unS.JugadoresExpulsados())
            {
                string resp = "";
                resp += $"Nombre: {j.NombreCompleto}\n";
                resp += $"Valor mercado: {j.ValorMercado}\n";
                Console.WriteLine(resp);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------\n");
        }

        static void MostrarPartidoMasGoles(string nombrePais)
        {
            Console.WriteLine($"Partido con más goles de {nombrePais} \n");
            (Partido partido, int goles) = unS.PartidoMasGoles(nombrePais);
            Console.WriteLine(partido);
            Console.WriteLine(goles);

        }

        static void MostrarJugadoresGoles()
        {
            foreach (Jugador i in unS.JugadoresGoles())
            {
                Console.WriteLine($"{i.NombreCompleto}- {i.ValorMercado} - {i.Categoria}");
            }
        }
    }
}
