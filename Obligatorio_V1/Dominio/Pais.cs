using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pais
    {
        public int IDPais { get; private set; }
        public string Nombre { get; set; }
        public string Alpha { get; set; }

        private static int uldId;

        public Pais(string nombre, string alpha)
        {
            IDPais = uldId++;
            Nombre = nombre;
            Alpha = alpha;

            Validar();
        }

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

        public override string ToString()
        {
            return $"Id {IDPais} - {Nombre} - {Alpha}";
        }
    }
}
