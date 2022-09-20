using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador
    {
        public int IDJugador { get; private set; }
        public string NombreCompleto { get; set; }
        public int NroCamisa { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Altura { get; set; }
        public string PieHabil { get; set; }
        public int ValorMercado { get; set; }
        public Pais Pais { get; set; }
        public string Puesto { get; set; }
        public int MontoRef { get; set; }

        private static int uldId;

        public Jugador()
        {
            IDJugador = uldId++;
        }

        public Jugador(string nombreCompleto, int nroCamisa, DateTime fechaNacimiento, float altura,string pieHabil, int valorMercado, string puesto, Pais pais)
        {
            IDJugador = uldId++;
            NombreCompleto = nombreCompleto;
            NroCamisa = nroCamisa;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PieHabil = pieHabil;
            ValorMercado = valorMercado;
            Puesto = puesto;
            Pais = pais;

            Validar();

        }

        public void Validar()
        {
            ValidarDatos();
        }

        public void ValidarDatos()
        {
            if (string.IsNullOrEmpty(NombreCompleto))
            {
                throw new Exception("Se recibio el nombre sin datos");
            } else if (NroCamisa == 0)
            {
                throw new Exception("Debe ingresar un numero de camisa");
            } else if (DateTime.Compare(FechaNacimiento, new DateTime(1111, 1, 1, 1, 1, 1)) < 0)
            {
                throw new Exception("Debe ingresar una fecha de nacimiento");
            }
            else if (string.IsNullOrEmpty(Puesto))
            {
                throw new Exception("Se recibio el puesto sin datos");
            } else if (Altura <= 0)
            {
                throw new Exception("Debe ingresar una altura válida");
            } else if (string.IsNullOrEmpty(PieHabil))
            {
                throw new Exception("Debe ingresar la pierna hábil");
            } else if (Pais == null)
            {
                throw new Exception("Debe ingresar un país");
            } else if (ValorMercado <= 0)
            {
                throw new Exception("Debe ingresar valor de mercado válido");
            }
        }

        public string DetCategoria()
        {
            if (ValorMercado <= MontoRef)
            {
                return "Estándar";
            }
            else
            {
                return "VIP";
            }
        }

        public override string ToString()
        {
            string texto = $"ID: {IDJugador} \n";
            texto += $"Nombre: {NombreCompleto} \n";
            texto += $"Numero de camisa: {NroCamisa} \n";
            texto += $"Fecha de nacimiento: {FechaNacimiento} \n";
            texto += $"Altura: {Altura} \n";
            texto += $"Valor en el mercado: {ValorMercado} \n";
            texto += $"Puesto: {Puesto} \n";
            texto += $"Pais: {Pais} \n";

            return texto;
        }
    }
}
