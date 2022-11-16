using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Operador
    {
        public int IDOperador { get; private set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime FechaEmpTrabajar { get; set; }

        private static int uldIdPer;


        public Operador()
        {
            IDOperador = uldIdPer++;
        }
        public Operador(string nombre, string email, string password, DateTime fechaEmpTrabajar)
        {
            IDOperador = uldIdPer++;
            NombreCompleto = nombre;
            Email = email;
            Password = password;
            FechaEmpTrabajar = fechaEmpTrabajar;
        }

        public bool Equals([AllowNull] Periodista other)
        {
            return Email.Equals(other.Email);
        }
    }
}
