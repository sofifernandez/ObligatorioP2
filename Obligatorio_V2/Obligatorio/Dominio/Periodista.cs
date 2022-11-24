using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Periodista: Usuario
    {

        private List<Reseña> _reseñas = new List<Reseña>();

        public List<Reseña> Reseñas
        {
            get { return _reseñas; }
        }

        public Periodista()
        {
            
        }
        public Periodista(string nombre, string apellido, string email, string password):base(nombre,apellido, email,password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
        }


        
        //-------------------------------RESEÑAS --------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public void AgregarResenia(Reseña resenia) 
        {
            Reseñas.Add(resenia);
        }

        public  List<Reseña> GetResenias()
        {
            return Reseñas;
        }

        //-------------------------------GENERALES-------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//


        public override string ToString()
        {
            string respuesta = "";
            respuesta += $"Nombre {Nombre} \n";
            respuesta += $"Nombre {Apellido} \n";
            respuesta += $"Mail {Email} \n";
            return respuesta;
        }

       
    }
}
