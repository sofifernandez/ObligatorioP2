using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace Dominio
{
    public abstract class Usuario : IEquatable<Usuario>, IComparable<Usuario>
    {

        public int IDUsuario { get; private set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private static int uldUsuario;


        public Usuario()
        {
            IDUsuario = uldUsuario++;
        }
        public Usuario(string nombre, string apellido, string email, string password)
        {
            IDUsuario = uldUsuario++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;

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
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido))
            {
                throw new Exception("Faltan el nombre");
            }
        }

        private void ValidarEmail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("No ingresó mail");
            }
            int indice = Email.IndexOf('@'); //--> chequear que el @ no esté al comienzo o al final
            if (indice <= 0 || indice >= Email.Length - 1)
            {
                throw new Exception("El formato del email es incorrecto");
            }

            int arrobas = 0;
            foreach (char s in Email) //--> chequear que el @ no esté más de una vez
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

        public bool Equals([AllowNull] Usuario other)
        {
            return Email.Equals(other.Email);
        }

        // FUNCIONES ABSTRACTAS
        public abstract List<Reseña> GetResenias();

        public int CompareTo([AllowNull] Usuario other)
        {
            int orden = Apellido.CompareTo(other.Apellido);
            if (orden == 0)
            {
                orden = Nombre.CompareTo(other.Nombre);
            }
            return orden;
        }
    }
}
