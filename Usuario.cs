using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal abstract class Usuario
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract void RealizarOferta(double oferta);
    }
}
