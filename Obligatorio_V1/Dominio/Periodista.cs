using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Periodista: IEquatable<Periodista>
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
            ValidarPeriodista();
        }


        //-------------------------------VALIDACIONES----------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//
        public void ValidarPeriodista()
        {
           
            ValidarNombre();
            ValidarEmail();
            ValidarPassword();
            
         }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreCompleto))
            {
                throw new Exception("Faltan el nombre para guardar al periodista");
            }
        }

        private void ValidarEmail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("No ingresó mail");
            }
            int indice = Email.IndexOf('@');
            if (indice <= 0 || indice >= Email.Length - 1)
            {
                throw new Exception("El formato del email es incorrecto");
            }

            int arrobas = 0;
            foreach(char s in Email)
            {
                if (s == '@')
                {
                    arrobas++;
                }
            }

            if (arrobas > 1)
            {
                throw new Exception("El formato del email es incorrecto");
            }
        }
        private void ValidarPassword()
        {
            if (Password.Length < 8)
            {
                throw new Exception("Contraseña con insuficiente cantidad de caracteres");
            }
        }

        //-------------------------------ToString-------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public bool Equals([AllowNull] Periodista other)
        {
            return Email.Equals(other.Email);
        }

        public override string ToString()
        {
            string respuesta = "";
            respuesta += $"ID {IDPerio} \n";
            respuesta += $"Nombre {NombreCompleto} \n";
            respuesta += $"Mail {Email} \n";

            //SI AL FINAL AGREGAMOS LAS RESEÑAS AL PERIODISTA HAY QUE LISTARLAS ACÁ.
            // O POR LO MENOS PONER: realizó tantas reseñas

            //respuesta += $"Realizó {Reseñas.Count} reseña/s \n";

            return respuesta;
        }

       
    }
}
