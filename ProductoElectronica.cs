using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal class ProductoElectronica : Producto
    {
        public ProductoElectronica(string nombre, double precioInicial, string descripcion) : base(nombre, precioInicial, descripcion)
        {
        }

        public override double CalcularPrecioFinal()
        {
            return PrecioInicial * 1.10; // Incremento del 10% por garantía.
        }
    }
}
