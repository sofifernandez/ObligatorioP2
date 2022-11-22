using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Periodista: Usuario
    {
       
        public List<Reseña> Reseñas = new List<Reseña>();      

        public Periodista()
        {
            
        }
        public Periodista(string nombre, string apellido, string email, string password):base(nombre,apellido, email,password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            //Reseñas = new List<Reseña>();
        }


        
        //-------------------------------RESEÑAS --------------------------------------------------------------------//
        //----------------------------------------------------------------------------------------------------------//

        public override void AgregarResenia(Reseña resenia) 
        {
            Reseñas.Add(resenia);
        }

        public override List<Reseña> GetResenias()
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
