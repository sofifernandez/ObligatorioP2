using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Periodista
    {
        public int IDPerio { get; private set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static int uldIdPer;

        public Periodista()
        {
            IDPerio = uldIdPer++;
        }
        public Periodista(string nombre, string email, string password)
        {
            IDPerio = uldIdPer++;
            NombreCompleto = nombre;
            Email = email;
            Password = password;
            //Validar();
        }

        //Validar--> ValidarEmail(), ValidarPassword()
    }
}
