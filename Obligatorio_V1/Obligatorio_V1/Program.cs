using Dominio;
using System;
using System.Collections.Generic;

namespace Obligatorio_V1
{
    class Program
    {
        static Sistema unS = Sistema.Instancia;
        static void Main(string[] args)
        {
            try
            {
                MostrarDatosprecarga();
                Menu();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hubo un error: {e.Message}");
                Console.ForegroundColor = ConsoleColor.White;

                Menu();
            }
        }

        static void MostrarDatosprecarga()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        /////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("    ///////////////////////////BIENVENIDOS///////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////// \n \n \n");

            Console.ForegroundColor = ConsoleColor.White;

            string resp = "Datos actuales:\n";
            resp += $"Jugadores: {unS.Jugadores.Count}\n";
            resp += $"Selecciones: {unS.Selecciones.Count}\n";
            resp += $"Paises: {unS.Paises.Count}\n";
            resp += $"Partidos: {unS.Partidos.Count}\n";
            Console.WriteLine(resp);
        }

        static void Menu()
        {
            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                MostrarMenu();
                Console.ForegroundColor = ConsoleColor.White;

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
            bool salir;
            int numero=0;

            do
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());
                    salir = true;
                }
                catch (Exception)
                {
                    salir = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Solo debe ingresar numeros. Intentalo de nuevo \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (!salir);

            return numero;
        }

        static void MenuAltaPeriodista()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre completo:");
                string nombreCompleto = Console.ReadLine();

                Console.WriteLine("Ingrese el email:");
                string email = Console.ReadLine();

                Console.WriteLine("Ingrese la contraseña:");
                string password = Console.ReadLine();

                unS.ArmarPeriodista(nombreCompleto, email, password);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Periodista agregado con éxito");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        static void MenuAsignarValorReferencia()
        {
            Console.WriteLine("Ingrese un monto, el cual servirá de referencia para calcular la categoria financiera de los jugadores:");
            //int monto = int.Parse(Console.ReadLine());
            int monto = PedirNumero();
            if (monto > 0)
            {
                unS.AgregarCategoria(monto);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"El monto ingresado fue de {monto}");
                Console.ForegroundColor = ConsoleColor.White;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elije un numero mayor a 0");
                Console.ForegroundColor = ConsoleColor.White;
            }

            
        }

        static void MenuPartidosDeJugador()
        {
            Console.WriteLine("Ingrese el ID de un jugador para mostrar todos los partidos en los que ha participado:");
            int id = PedirNumero();

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

        

        //-------------------------------MOSTRAR DATA---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
            

        static void MostrarPartidosJugador (int IDJugador)
        {
            Jugador unJ = unS.GetJugador(IDJugador);
            if (unJ != null)
            {
                List<Partido> partidosDelJugador = unS.PartidosJugador(IDJugador);
                if (partidosDelJugador.Count > 1)
                {
                    foreach (Partido p in partidosDelJugador)
                    {
                        Console.WriteLine($"Partidos jugados por {unJ.NombreCompleto}:\n");
                        string resp = "";
                        resp += $"Partido: {p.SeleccionA.Pais.Nombre} vs {p.SeleccionB.Pais.Nombre}\n";
                        resp += $"Fecha: {p.FechaPartido}\n";
                        resp += $"Incidencias: {p.Incidencias.Count}";
                        Console.WriteLine(resp);
                    }
                } else
                {
                    Console.WriteLine($"El Jugador {unJ.NombreCompleto} aún no ha jugado ningun partido \n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El jugador seleccionado no existe");
                Console.ForegroundColor = ConsoleColor.White;
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
            try
            {
                Console.WriteLine($"Partido con más goles de {nombrePais} \n");
                (Partido partido, int goles) = unS.PartidoMasGoles(nombrePais);
                if (partido!=null)
                {
                    Console.WriteLine(partido);
                    Console.WriteLine(goles);
                }
                else 
                {
                    Console.WriteLine($"La selección de {nombrePais} no ha jugado ningún partido");
                }
            }
            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        static void MostrarJugadoresGoles()
        {
            foreach (Jugador i in unS.JugadoresGoles())
            {
                Console.WriteLine($"{i.NombreCompleto}- {i.ValorMercado} - {(!string.IsNullOrEmpty(i.Categoria) ? i.Categoria : "Definir valor de referencia (opción 2) ")}");
            }
        }
    }
}
