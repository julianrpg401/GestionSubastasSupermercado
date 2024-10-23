using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal class ProductoAlimento : Producto
    {
        public ProductoAlimento(string nombre, double precioInicial, string descripcion) : base(nombre, precioInicial, descripcion)
        {
        }

        public DateTime FechaCaducidad { get; set; }

        public override double CalcularPrecioFinal()
        {
            if (FechaCaducidad <= DateTime.Now.AddDays(7)) // Cerca de la caducidad
                return PrecioInicial * 0.85; // Descuento del 15%.

            return PrecioInicial;
        }
    }
}
