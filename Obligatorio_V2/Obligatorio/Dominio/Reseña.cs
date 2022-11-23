using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dominio
{
    public class Reseña: IComparable<Reseña>
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPubli { get; set; }
        public Periodista UnPeriodista { get; set; }
        public Partido PartidoRes { get; set; }

        public Reseña(string titulo, string contenido, DateTime fecha, Periodista periodista, Partido partido)
        {
            Titulo = titulo;
            Contenido = contenido;
            FechaPubli = fecha;
            UnPeriodista = periodista;
            PartidoRes = partido;
            ValidarReseña();
        }


        private void ValidarReseña()
        {
            if (string.IsNullOrEmpty(Titulo))
            {
                throw new Exception("Debe ingresar un título");
            }

            if (string.IsNullOrEmpty(Contenido))
            {
                throw new Exception("Debe ingresar contenido de la reseña");
            }

            if (FechaPubli == new DateTime(0001, 01, 01))
            {
                throw new Exception("Debe seleccionar una fecha de publicación");
            }

            if (!PartidoRes.Finalizado)
            {
                throw new Exception("El partido aún no ha finalizado");
            }
        }



        public int CompareTo([AllowNull] Reseña other)
        {
            return FechaPubli.CompareTo(other.FechaPubli) * -1;
        }
    }
}
