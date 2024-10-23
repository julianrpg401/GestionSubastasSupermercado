using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal abstract class Producto
    {
        private string nombre;
        private double precioInicial;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioInicial { get => precioInicial; set => precioInicial = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Producto(string nombre, double precioInicial, string descripcion)
        {
            this.nombre = nombre;
            this.precioInicial = precioInicial;
            this.descripcion = descripcion;
        }

        public abstract double CalcularPrecioFinal();
    }
}
