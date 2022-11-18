using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Operador : Usuario
    {

        public DateTime FechaEmpTrabajar { get; set; }
        public Operador()
        {
            
        }
        public Operador(string nombre, string apellido, string email, string password, DateTime fechaEmpTrabajar) : base(nombre, apellido, email, password)
        {

            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            FechaEmpTrabajar = fechaEmpTrabajar;
        }


        public override List<Reseña> GetResenias()
        {
            return null;
        }
    }
}
