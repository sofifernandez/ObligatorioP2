using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Jugador: IEquatable<Jugador>, IComparable<Jugador>
    {
        public int IDJugador { get; private set; }
        public string NombreCompleto { get; set; }
        public string NroCamisa { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public string PieHabil { get; set; }
        public int ValorMercado { get; set; }
        public string Moneda { get; set; }
        public Pais Pais { get; set; }
        public string Puesto { get; set; }
        public string Categoria { get; set; }

        private static int uldId;

        public Jugador()
        {
            IDJugador = uldId++;
        }

        public Jugador(int iDJugador, string nroCamisa, string nombreCompleto, DateTime fechaNacimiento, double altura,string pieHabil, int valorMercado, string moneda,Pais pais, string puesto)
        {
            IDJugador = iDJugador;
            NombreCompleto = nombreCompleto;
            NroCamisa = nroCamisa;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PieHabil = pieHabil;
            ValorMercado = valorMercado;
            Moneda = moneda;
            Puesto = puesto;
            Pais = pais;
            Validar();

        }
        //-------------------------------VALIDAR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void Validar()
        {
            ValidarDatos();
        }

        public void ValidarDatos()
        {
            if (string.IsNullOrEmpty(NombreCompleto))
            {
                throw new Exception("Se recibio el nombre sin datos");
            } else if (NroCamisa == "")
            {
                throw new Exception("Debe ingresar un numero de camisa");
            } else if (DateTime.Compare(FechaNacimiento, new DateTime(1111, 1, 1, 1, 1, 1)) < 0)
            {
                throw new Exception("Debe ingresar una fecha de nacimiento");
            }
            else if (string.IsNullOrEmpty(Puesto))
            {
                throw new Exception("Se recibio el puesto sin datos");
            } else if (Altura < 0) //--> hay un par de alturas que son 0, así que ponemos menor a 0
            {
                throw new Exception("Debe ingresar una altura válida");
            } else if (string.IsNullOrEmpty(PieHabil))
            {
                throw new Exception("Debe ingresar la pierna hábil");
            } else if (Pais == null)
            {
                throw new Exception("Debe ingresar un país");
            } else if (ValorMercado < 0) //--> hay un par de valores que son 0, así que ponemos menor a 0
            {
                throw new Exception("Debe ingresar valor de mercado válido");
            }
        }

        //-------------------------------CATEGORIA---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void DetCategoria(int MontoRef) //--> definir categoría de cada jugador según el monto ingresado en el programa
        {
            if (ValorMercado <= MontoRef)
            {
                Categoria=  "Estándar";
            }
            else
            {
                Categoria = "VIP";
            }
        }

        //-------------------------------GENERALES---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public bool Equals([AllowNull] Jugador other)
        {
            return IDJugador.Equals(other.IDJugador);
        }

        public int CompareTo([AllowNull] Jugador other)
        {
            int orden = ValorMercado.CompareTo(other.ValorMercado) *-1; //--> descendente
            if (orden == 0)
            {
                orden = NombreCompleto.CompareTo(other.NombreCompleto); //--> ascendente
            }
            return orden;
        }
        public override string ToString()
        {
            string texto = $"ID: {IDJugador} \n";
            texto += $"Numero de camisa: {NroCamisa} \n";
            texto += $"Nombre: {NombreCompleto} \n";
            texto += $"Fecha de nacimiento: {FechaNacimiento} \n";
            texto += $"Altura: {Altura} \n";
            texto += $"Pie hábil: {PieHabil} \n";
            texto += $"Valor en el mercado: {ValorMercado} \n";
            texto += $"Moneda: {Moneda} \n";
            texto += $"Puesto: {Puesto} \n";
            texto += $"Pais: {Pais.Nombre} \n";
            if(string.IsNullOrEmpty(Categoria))
            {
                texto += $"Categoria: Debes establecer el monto de referencia en el menu (opcion 2) \n";
            } else
            {

                texto += $"Categoria: {Categoria} \n";
            }
            return texto;
        }

        
    }
}
