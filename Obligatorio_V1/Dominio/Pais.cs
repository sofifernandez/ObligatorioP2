using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Pais: IEquatable<Pais>
    {
        public int IDPais { get; private set; }
        public string Nombre { get; set; }
        public string Alpha { get; set; }

        private static int uldId=0;

        public Pais(string nombre, string alpha)
        {
            IDPais = uldId++;
            Nombre = nombre;
            Alpha = alpha;

            Validar();
        }

        //-------------------------------VALIDAR---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void Validar()
        {
            ValidarNombre();
            ValidarAlpha();
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Se recibio el nombre sin datos");
            }
        }

        public void ValidarAlpha()
        {
            if (Alpha.Length != 3)
            {
                throw new Exception("El codigo alpha debe constar de 3 caracteres");
            }
        }

        //-------------------------------GENERAL---------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public override string ToString()
        {
            return $"Id {IDPais} - {Nombre} - {Alpha}";
        }


        public bool Equals([AllowNull] Pais other)
        {
            return Nombre.Equals(other.Nombre);
        }
    }
}
