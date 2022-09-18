using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema _instancia;
        private List<Partido> _partidos = new List<Partido>();
        private List<Periodista> _periodistas = new List<Periodista>();

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }
    }
}
