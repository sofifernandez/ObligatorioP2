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
        public int ValorMercado { get; set; }
        public Pais Pais { get; set; }
        public string Puesto { get; set; }
        public int MontoRef { get; set; }

        private static int uldId;

        public Jugador()
        {
            IDJugador = uldId++;
        }

        public Jugador(string nombreCompleto, int nroCamisa, DateTime fechaNacimiento, float altura, int valorMercado, string puesto, Pais pais)
        {
            IDJugador = uldId++;
            NombreCompleto = nombreCompleto;
            NroCamisa = nroCamisa;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            ValorMercado = valorMercado;
            Puesto = puesto;
            Pais = pais;

            //Validar()

        }

        public void Validar()
        {
            ValidarNombre();
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreCompleto))
            {
                throw new Exception("Se recibio el nombre sin datos");
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
