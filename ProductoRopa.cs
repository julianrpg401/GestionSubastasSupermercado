using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal class ProductoRopa : Producto
    {
        public bool EsLiquidacion { get; set; }

        public ProductoRopa(string nombre, double precioInicial, string descripcion) : base(nombre, precioInicial, descripcion)
        {
        }

        public override double CalcularPrecioFinal()
        {
            if (EsLiquidacion)
                return PrecioInicial * 0.80; // Descuento del 20% en liquidación.

            return PrecioInicial;
        }
    }
}
